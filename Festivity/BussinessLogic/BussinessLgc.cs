using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess; // for acessing DataAccess class
using BussinessObject; // for acessing bussiness object class
using System.IO;
using Google.API.Search;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.Services;

namespace BussinessLogic
{
    public class BussinessLgc
    {
        #region Public Methods
            DtAccess objDataAccess = new DtAccess();
            const string _spName = "sp_Procedure";

            public DataTable SearchImageByGoogle(BussinessObj objBussiness)
            {
                
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Title", typeof(string)));
                dt.Columns.Add(new DataColumn("OriginalContextUrl", typeof(string)));
                dt.Columns.Add(new DataColumn("Url", typeof(string)));
                GimageSearchClient client = new GimageSearchClient("www.Google.com");
                IList<IImageResult> results = client.Search(objBussiness.Search, 30);
                foreach (IImageResult result in results)
                {
                    DataRow dr = dt.NewRow();
                    dr["Title"] = result.Title.ToString();
                    dr["OriginalContextUrl"] = result.OriginalContextUrl;
                    dr["Url"] = result.Url;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            public void ImagesGenerateThumbnail(BussinessObj objBussiness)
            {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(objBussiness.SenderArgument);
                string url = objBussiness.SenderArgument;
                string fileName = String.Join(string.Empty, url.Substring(url.LastIndexOf('/') + 1).Split('-'));
                System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(imageData);
                Bitmap objBm = new Bitmap((Bitmap)System.Drawing.Image.FromStream(streamBitmap));
                using (System.Drawing.Image thumbnail = objBm.GetThumbnailImage(Convert.ToInt32(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), Convert.ToInt32(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        thumbnail.Save(memoryStream, ImageFormat.Png);
                        Byte[] bytes = new Byte[memoryStream.Length];
                        memoryStream.Position = 0;
                        memoryStream.Read(bytes, 0, (int)bytes.Length);
                        objBussiness.FileName = fileName;
                        objBussiness.Bytes = bytes;                        
                    }
                }
            }
            public int InsertImage(BussinessObj objBussiness)
            {
                System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(objBussiness.Image);
                Bitmap objBm = new Bitmap((Bitmap)System.Drawing.Image.FromStream(streamBitmap));
                using (System.Drawing.Image thumbnail = objBm.GetThumbnailImage(140, 110, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        thumbnail.Save(memoryStream, ImageFormat.Png);
                        Byte[] bytes = new Byte[memoryStream.Length];
                        memoryStream.Position = 0;
                        memoryStream.Read(bytes, 0, (int)bytes.Length);
                        objBussiness.FileName = objBussiness.ImageCategory;
                        objBussiness.SmallImage = bytes;
                    }
                }

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@Mode", "InsertImage");
                param[1] = new SqlParameter("@CategoryID", objBussiness.ID);
                param[2] = new SqlParameter("@Image", objBussiness.Image);
                param[3] = new SqlParameter("@SmallImage", objBussiness.SmallImage);
                return objDataAccess.ExecuteNonQuery(_spName, param);
            }
            public DataTable SearchImageByDatabase(BussinessObj objBussiness)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Mode", "SelectImage");
                param[1] = new SqlParameter("@Search", objBussiness.ID);
                DataTable dtEmployee = new DataTable();
                dtEmployee = objDataAccess.ExecuteDataset(_spName, param).Tables[0];
                return dtEmployee;
            }

            public DataTable SelectAllImage(BussinessObj objBussiness)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Mode", "SelectAllImage");
                DataTable dtEmployee = new DataTable();
                dtEmployee = objDataAccess.ExecuteDataset(_spName, param).Tables[0];
                return dtEmployee;
            }

            public DataTable SearchAllCategory(BussinessObj objBussiness)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Mode", "SearchAllCategory");
                DataTable dtEmployee = new DataTable();
                dtEmployee = objDataAccess.ExecuteDataset(_spName, param).Tables[0];
                return dtEmployee;
            }

            public DataSet SelectCategory(BussinessObj objBussiness)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@Mode", "SearchAllCategory");
                    ds = objDataAccess.ExecuteDataset(_spName, param);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex);
                }
            }

            public DataSet InsertCategory(BussinessObj objBussiness)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = new SqlParameter[4];
                    param[0] = new SqlParameter("@Mode", "InsertCategory");
                    param[1] = new SqlParameter("@ImageCategory", objBussiness.ImageCategory);
                    param[2] = new SqlParameter("@outmessage", SqlDbType.NVarChar, 150);
                    param[2].Direction = ParameterDirection.Output;
                    ds = objDataAccess.ExecuteDataset(_spName, param);
                    objBussiness.Message = Convert.ToString(param[2].Value);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex);
                }
            }

            public DataSet SelectAllCategory(BussinessObj objBussiness)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = new SqlParameter[6];
                    param[0] = new SqlParameter("@Mode", "SelectAllCategory");
                    ds = objDataAccess.ExecuteDataset(_spName, param);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex);
                }
            }

            public DataSet DeleteCategory(BussinessObj objBussiness)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = new SqlParameter[4];
                    param[0] = new SqlParameter("@Mode", "DeleteCategory");
                    param[1] = new SqlParameter("@ID", objBussiness.ID);
                    param[2] = new SqlParameter("@outmessage", SqlDbType.NVarChar, 150);
                    param[2].Direction = ParameterDirection.Output;
                    ds = objDataAccess.ExecuteDataset(_spName, param);
                    objBussiness.Message = Convert.ToString(param[2].Value);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex);
                }
            }
            public Stream SelectImageByID(int theID)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Mode", "SelectImageByID");
                param[1] = new SqlParameter("@ID", theID);
                object theImg = objDataAccess.ExecuteScalar(_spName, param);

                try
                {
                    return new MemoryStream((byte[])theImg);
                }
                catch
                {
                    return null;
                }
            }

            public void ImagesGenerateThumbnailFromDatabase(BussinessObj objBussiness)
            {
                try
                {
                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@Mode", "ImagesGenerateThumbnailFromDatabase");
                    param[1] = new SqlParameter("@ID", objBussiness.ID);
                    using (SqlDataReader sdr = objDataAccess.ExecuteReader(_spName, param))
                    {
                        sdr.Read();
                        objBussiness.Image = (byte[])sdr["Image"];
                    }

                    System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(objBussiness.Image);
                    Bitmap objBm = new Bitmap((Bitmap)System.Drawing.Image.FromStream(streamBitmap));
                    using (System.Drawing.Image thumbnail = objBm.GetThumbnailImage(Convert.ToInt32(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), Convert.ToInt32(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            thumbnail.Save(memoryStream, ImageFormat.Png);
                            Byte[] bytes = new Byte[memoryStream.Length];
                            memoryStream.Position = 0;
                            memoryStream.Read(bytes, 0, (int)bytes.Length);
                            objBussiness.FileName = objBussiness.ImageCategory;
                            objBussiness.Bytes = bytes;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex);
                }
            }
            public bool ThumbnailCallback()
            {
                return false;
            }
        #endregion
    }
}
