using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
    //интерфейс нешего проекта, где записаны прототипы всех методов проекта
{
    interface GoodVisionInterface
    {
        void Create_account(string Nickname);//функция для создания аккаунта
        void Clear_account(UserClass User);//удалить аккаунт

        void Enter_account();//войти в аккаунт

        void Get_Stats(UserClass User);//узнать статистику пользователя
        void Test_vision();//переход в окно для выбора режима проверки зрения
        void Test_vision_with_letters(UserClass User);//не требует пояснения
        void Test_vision_with_circles(UserClass User);//это тоже

        void Settings();//войти в настройки
        void Get_help();//получить хелпу
    }
}
