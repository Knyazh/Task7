using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Common
{
    public  class TranslatorAz
    {
        public const string INTRO = "Xosh gelmisiniz  ";
        public const string OPTION = "Sizin sechim:";
        public const string SUCCESFULL_ADDING = "Ugurla elave olundu";
        public const string NOT_FOUND = "Tapilmadi";
        public const string BLOG_NOT_FOUND = $"Blog Tapilmadi";
        public const string INVALID_LOG_OR_PASS = $"Login ve ya parol sehvdir";
        public const string INVALID_EMAIL = "Bele email yoxdur";
        public const string INVALID_PASSWORD = "Sehv parol";
        public const string ALREADY_BANNED_ACCOUNT = "Hesab bandadir";
        public const string ADMIN_CANT_BE_BANNED = "Admini banlaya bilmezsiniz";
        public const string SUCCESFULL_BANNED_USER = "User ugurla banlandi!";
        public const string BLOG_BODY_INPUT = "Zehmet olmada megzi daxil edin";
        public const string BLOG_TITLE_INPUT = "Zehmet olmada blogun bashligini yazin";
        public const string INCORRECT_LENGTH = "Uzunluq yalnishdir";
        public const string EMAIL_REQUEST = "Emaili daxil edin";
        public const string EXSISTING_EMAIL = "bele Email var";
        public const string NAME_REQUEST = "Adinizi daxil edin";
        public const string SURNAME_REQUEST = "Soyadinizi daxil edin";
        public const string PASSWORD_REQUEST_AGAIN = "Parolunuzu tezden daxil edin";
        public const string PASSWORD_REQUEST = "Parolunuzu daxil edin";
        public const string ADMIN_CANT_BE_REMOVED = "Admin siline bilmez";
        public const string ENTER_CORECT_FORMAT = "Duzgun daxil edin";
        public const string SUCCESFULLY_DELETED = "Ugurla silindi";
        public const string ID_REQUEST = "Id ni daxil edin";
        public const string ALREADY_ADMIN = "Admindir";
        public const string ALREADY_USER = "Userdir";
        public const string PROMOTED_TO_ADMIN = "Admin oldu";
        public const string DEPROMOTE_FROM_ADMIN = "User oldu";
        public const string SUCCESSFULLY = "Ugurla edildi!";
        public const string MESSAGE_SENDED = "Ugurla gonderildi!";
        public const string CLIENT_DASHBOARD_INTRO = "Xosh gelmisiniz";



        public const string ADMINDASHBOARD = 
               "Ne etmek isteyirsiz?\n" +
               "1-Butun Userleri goster\n" +
               "2-Useri id-sine gore sil\n" +
               "3-Useri Admin ele\n" +
               "4-Admini user ele\n" +
               "5-Shexsi Melumati deyishdir\n" +
               "6-Useri email-ne gore sil\n" +
               "7-Ban user\n" +
               "8-Mesaj gonder\n" +
               "9-Qebul olunmush bloglari goster\n" +
               "10-Redd edilmish bloglari goster\n" +
               "0-Logout";


        public const string LANGUAGE_CHANGE = "Hansi dile kechmek isteyirsiniz\n" +
                    "1-Aze\n" +
                    "2-Rus\n" +
                    "3-Eng\n";
        public const string CLIENT_DASHBOARD_INDEX = "Ne elemek isteyirsiniz\n" +
                    "1-Shexsi Melumati deyishdir\n" +
                    "2-Hesabi Bagla\n" +
                    "3-Mesajlara bax!\n" +
                    "0-Cixish";

        public const string MAIN_SELECT_OPTIONS = "Ne elemek isteyirsiniz\n" +
                    "1-Login\n" +
                    "2-Register\n" +
                    "3-Cixish\n" +
                    "4-Dili deyish";
    }
}
