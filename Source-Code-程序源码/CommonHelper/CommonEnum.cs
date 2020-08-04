using System.ComponentModel;

namespace CommonHelper
{
    public class CommonEnum
    {
        public enum CodingEnum
        {
            JS_Escape,
            JS_EncodeURI,
            JS_EncodeURIComponent,
            Unicode,
            //UTF8
        }

        public enum EncryptEnum
        {
            Base64,
            AES,
            DES,
            //RC4,
            //Rabbit,
            //TripleDes,
            //迅雷地址,
            //快车地址,
            //旋风地址
        }

        public enum WordFileToFormatEnum
        {
            pdf,
            html,
            txt,
            docx,
            doc
        }

        public enum ExcelFileToFormatEnum
        {
            pdf,
            html,
            xlsx,
            xls
        }
    }
}