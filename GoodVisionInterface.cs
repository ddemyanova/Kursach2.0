using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
{
    interface GoodVisionInterface
    {
        void Create_account(string Nickname);
        void Clear_account(UserClass User);

        void Enter_account();

        void Get_Stats(UserClass User);
        void Test_vision_with_letters(UserClass User);
        void Test_vision_with_circles(UserClass User);

        void Settings();
        void Get_help();

    }
}
