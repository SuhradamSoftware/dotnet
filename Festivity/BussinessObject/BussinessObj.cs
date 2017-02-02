using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class BussinessObj
    {
        #region Variables
            protected int _ID; 
            protected string _Search = String.Empty;
            protected string _SenderArgument = String.Empty;
            protected string _Height = String.Empty;
            protected string _width = String.Empty;
            protected string _Message = String.Empty;
            protected string _FileName = String.Empty;
            protected Byte[] _Bytes = null;
            protected Byte[] _Image = null;
            protected Byte[] _SmallImage = null;
            protected string _ImageCategory = String.Empty;

            public int ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            public string Search
            {
                get { return _Search; }
                set { _Search = value; }
            }
            public string SenderArgument
            {
                get { return _SenderArgument; }
                set { _SenderArgument = value; }
            }
            public string Height
            {
                get { return _Height; }
                set { _Height = value; }
            }
            public string width
            {
                get { return _width; }
                set { _width = value; }
            }
            public string FileName
            {
                get { return _FileName; }
                set { _FileName = value; }
            }
            public Byte[] Bytes
            {
                get { return _Bytes; }
                set { _Bytes = value; }
            }
            public Byte[] Image
            {
                get { return _Image; }
                set { _Image = value; }
            }
            public Byte[] SmallImage
            {
                get { return _SmallImage; }
                set { _SmallImage = value; }
            }
            public string ImageCategory
            {
                get { return _ImageCategory; }
                set { _ImageCategory = value; }
            }
            public string Message
            {
                get { return _Message; }
                set { _Message = value; }
            }
        #endregion
    }
}
