using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace testBot
{
    internal class Buttons
    {
        public static IReplyMarkup? GetButtons()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Регистрация") }
                },
                ResizeKeyboard = true
            };
        }
        public static IReplyMarkup? GetButtons1()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Только трудоустроился"), new KeyboardButton("Действующий сотрудник") }
                },
                ResizeKeyboard = true
            };
        }

        public static IReplyMarkup? GetButtons2()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("О компании"), new KeyboardButton("Наша команда"), new KeyboardButton("События компании") },
                    new List<KeyboardButton> { new KeyboardButton("Справки"), new KeyboardButton("Кодекс поведения киберметаллурга"), new KeyboardButton("Бонусы и льготы") },
                    new List<KeyboardButton> { new KeyboardButton("Ключевые правила безопасности ") }

                },
                ResizeKeyboard = true
            };
        }
        public static IReplyMarkup? GetButtons3()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Только трудоустроился"), new KeyboardButton("Действующий сотрудник") }
                },
                ResizeKeyboard = true
            };
        }
        public static IReplyMarkup? GetButtons4()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Правила поведения на территории"), new KeyboardButton("Дресс-код"), new KeyboardButton("График работы и отдыха") },
                    new List<KeyboardButton> { new KeyboardButton("Назад") }
                },
                ResizeKeyboard = true
            };
        }
        public static IReplyMarkup? GetButtons5()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Что можно носить"), new KeyboardButton("Это мы точно не носим") },
                    new List<KeyboardButton> { new KeyboardButton("Назад") }
                },
                ResizeKeyboard = true
            };
        }

        public static IReplyMarkup? BotWriting()
        {
            return new ReplyKeyboardMarkup("")
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("Подождите, бот печатает сообщение")}
                },
                ResizeKeyboard = true
            };
        }
    }
}
