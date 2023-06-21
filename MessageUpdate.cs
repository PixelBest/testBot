using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace testBot
{
    internal class MessageUpdate
    {
        public static async Task Mes(ITelegramBotClient botClient, Update update, CancellationToken cancellation)
        {
            var up = update?.Message?.Text;
            var message = update?.Message;

            switch (up)
            {
                case "/start":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Привет, я бот Киберкот, цифровой помощник киберметаллурга.  В этом боте ты узнаешь, чем так важна твоя работа, какая миссия каждый день вдохновляет нас делать свое дело и что мы больше всего ценим в работе и в друг друге. Для начала давай познакомимся:", replyMarkup: Buttons.GetButtons2());
                    break;

                case "Регистрация":

                    ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                             {
                                KeyboardButton.WithRequestContact("Оставить контакт")
                            })
                    {
                        ResizeKeyboard = true
                    };

                    await botClient.SendTextMessageAsync(chatId: update.Message.Chat.Id,
                                                         text: "Поделитесь номером телефона",
                                                         replyMarkup: replyKeyboardMarkup,
                                                         cancellationToken: cancellation);


                    break;

                case "Действующий сотрудник":

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Что вы хотите узнать", replyMarkup: Buttons.GetButtons2());
                    break;

                case "Только трудоустроился":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Что вы хотите узнать", replyMarkup: Buttons.GetButtons2());
                    break;

                case "О компании":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ты освоил профильное образование и получил дополнительные навыки, востребованные на производстве. Хорошо понимаешь, как обращаться с современной техникой, чтобы получить наилучший результат, соблюдая при этом меры безопасности и охраны труда. ", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ты оптимист, ведёшь здоровый образ жизни, не используешь ненормативную лексику, честен с собой и коллегами – потому что целеустремлён, понимаешь свои карьерные перспективы в компании, проявляешь инициативу и расширяешь границы знаний.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ты стрессоустойчив, мотивирован, надёжен и дисциплинирован, потому что сфокусирован на общем результате, чувствуешь ответственность за него, за себя и своих коллег.", replyMarkup: Buttons.GetButtons2());
                    break;

                case "Наша команда":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Познакомься с нашими вдохновителями – руководящей командой Cybersteel. Следуя за ними, тысячи сотрудников делают успехи каждый день.", replyMarkup: Buttons.GetButtons2());
                    break;

                case "События компании":
                    break;

                case "Справки":
                    break;

                case "Кодекс поведения киберметаллурга":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Я познакомлю тебя с правилами поведения и действующим дресс-кодом", replyMarkup: Buttons.GetButtons4());
                    break;

                case "Правила поведения на территории":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "1. Приходит на работу вовремя и хорошо отдохнувшим.\r\n2. Следует правилам трудового распорядка, устным и письменным инструкциям.\r\n3. На площадке следует требованиям предупредительных, запрещающих плакатов и знаков.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "1. Не выполняет работу за других и не мешает им работать.\r\n2. Не покидает рабочее место на перерыв по окончании рабочего дня, не предупредив об этом своего руководителя.\r\n3. Не находится на участках, которые не относятся к зоне его деятельности без разрешения руководителя.", replyMarkup: Buttons.GetButtons4());
                    break;

                case "Дресс-код":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Что вас больше интересует?", replyMarkup: Buttons.GetButtons5());
                    break;

                case "Что можно носить":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Офис\r\nВы можете ходить ма работу и в деловой, и в менее строгой одежде: например, в джинсах и футболке. Конечно, если предстоит важная встреча, лучше всё-таки брюки — уверены, вы и сами это понимаете.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Производство\r\nВы ведь уже получили спецодежду? Отлично! Тогда всё просто: носите её — мы старались сделать её удобной и красивой. А пока вы не переоделись, приходите в деловой или повседневной одежде: спортивные костюмы и гавайские рубашки оставьте для выходных.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Предпочтительные цвета\r\nСкромные оттенки, отсутсвие ярких, кричащих рисунков ", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Девушкам\r\nУмеренный макияж, бижутерия, аккуратный маникюр", replyMarkup: Buttons.GetButtons5());
                    break;

                case "Это мы точно не носим":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "1. Одежду ярких, кислотных цветов\r\n2. Спортивные костюмы\r\n3. Протертые или рваные джинсы\r\n4. Прозрачные блузки\r\n5. Мини-юбки\r\n6. Шлепанцы, сандали (даже с носками)\r\n7. Верхняя одежда и головные уборы\r\n8. Шорты (искл. женские костюмные шорты не выше 10 см от колен)", replyMarkup: Buttons.GetButtons5());
                    break;

                case "Назад":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Возвращаю вас в главное меню", replyMarkup: Buttons.GetButtons2());
                    break;

                case "График работы и отдыха":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "В офисе\r\nМы с коллегами ждем тебя в офисе в утвержденные в твоем трудовом договоре часы. Не забывай уделить время для обеда и отдыха с 12 до 15 часов. Если необходимо изменить график работы - ты всегда можешь обратиться к руководителю. Главное, чтобы это не нарушало производственный процесс.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "На производстве\r\nРад видеть тебя на производстве по твоему утвержденному графику: с 8:00 до 16:30 при 8-часовой смене и с 17:00 до 06:00 при 12 часовой смене.\r\nНе забывай уделить себе время для питания и отдыха, полчаса при занятости 8 часов и 72 минуты, если работаешь 12 часов.", replyMarkup: Buttons.GetButtons4());
                    break;

                case "Бонусы и льготы":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "1 раз в 3 года дополнительный день для прохождения диспансеризации.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "+ 7 дней оплачиваемого отпуска, приоритет отпуска летом. Бесплатные путевки во время летних каникул в пределах квоты для многодетных матерей.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "До 1500 рублей в месяц компенсация затрат на абонемент в фитнесцентр, секции.", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "1 000 рублей за каждый отработанный год непрерывного стажа в CYBERSTEEL за выслугу от 3 до 20 лет", replyMarkup: Buttons.BotWriting());
                    await Task.Delay(3000);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Выплаты при рождении 7 000 рублей.– при рождении первого 10 000 рублей – при рождении второго 15 000 рублей – при рождении третьего", replyMarkup: Buttons.GetButtons2());
                    break;

                case "Ключевые правила безопасности":
                    break;
            }
        }
    }
}
