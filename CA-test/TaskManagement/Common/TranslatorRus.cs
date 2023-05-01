using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Common
{
    internal class TranslatorRus
    {
        public const string CHOICE_OPTION = "Ваш выбор:";
        public const string SUCCESFULL_ADDING = "Успешно добавлено";
        public const string NOT_FOUND = "Не найдено";
        public const string ADMINDAHSBOARD_INTRO = "Добро пожаловать вновь уважаемый ";
        public const string INTRO_FOR_SYSTEM = "Добро пожаловать login/register app";

        public const string BLOG_NOT_FOUND = $"Такого блога нету";
        public const string INVALID_EMAIL = "Такого емеила нету";
        public const string INVALID_LOG_OR_PASS = $"Неверный логин или пароль";
        public const string INVALID_PASSWORD = "Неверный пароль";
        public const string NAME_REQUEST = "Пожалуйста, введите имя";
        public const string SURNAME_REQUEST = "Пожалуйста, введите фамилию";
        public const string PASSWORD_REQUEST = "Пожалуйста, введите пароль";
        public const string PASSWORD_REQUEST_AGAIN = "Пожалуйста, введите пароль еще раз";
        public const string ALREADY_BANNED_ACCOUNT = "Забаненный акк";
        public const string ADMIN_CANT_BE_BANNED = "Вы неможете забанить админа";
        public const string SUCCESFULL_BANNED_USER = "Успешно забанен!";
        public const string BLOG_BODY_INPUT = "Пожалуйста введиде текст";
        public const string BLOG_TITLE_INPUT = "Пожалуйста введиде заголовок блога";
        public const string INCORRECT_LENGTH = "Не правильное длина текста";
        public const string EMAIL_REQUEST = "Пожалуйста введите Емаил";
        public const string EXSISTING_EMAIL = "Такой Email существует";
        public const string ADMIN_CANT_BE_REMOVED = "Админ не можеть быть удалён";
        public const string ENTER_CORECT_FORMAT = "Введите правильно";
        public const string SUCCESFULLY_DELETED = "Успешно удалён";
        public const string ID_REQUEST = "Введите ID";
        public const string ALREADY_ADMIN = "так и так Админ";
        public const string ALREADY_USER = "Так и так Усер";
        public const string PROMOTED_TO_ADMIN = "Стал админом";
        public const string DEPROMOTE_FROM_ADMIN = "Стал усером";
        public const string FORBIDDEN = "Нельзя!!";
        public const string SUCCESSFULLY = "Успешно!!";
        public const string MESSAGE_SENDED = "Успешно отправлено!!";

        public const string CLIENT_DASHBOARD_INTRO = "Добро пожаловать";


        public const string CLIENT_DASHBOARD_INDEX = "Что вы хотите сделать?\n" +
            "1-Обновить настройки\n" +
            "2-Закрыть аккаунт\n" +
            "3-Просмотреть сообщения\n" +
            "4-Добавить блог\n" +
            "0-Выйти";


        public const string LANGUAGE_CHANGE_OPTIONS = "На какой язык хотите перейти\n" +
                    "1-Aze\n" +
                    "2-Рус\n" +
                    "3-Eng\n";



        public const string MAIN_SELECT_OPTIONS = "Что хотите сделать\n" +
                    "1-Логин\n" +
                    "2-Регистрация\n" +
                    "3-Выход\n" +
                    "4-Сменить язык";


        public const string ADMINDASHBOARD = "Что хотите сделать?\n" +
               "1-Показать всех участников\n" +
               "2-Удалить пользователья по ID\n" +
               "3-Повышить до администратора\n" +
               "4-Понизить до Member\n" +
               "5-Редактировать Данные\n" +
               "6-Удалит по Email\n" +
               "7-Забанить userа\n" +
               "8-Отправить сообщение\n" +
               "9-Зарегистрировать нового Userа\n" +
               "10-Показать принятые Блоги\n" +
               "0-Выйти из системы";
    }
}
