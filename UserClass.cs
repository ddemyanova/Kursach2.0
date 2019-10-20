using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
{
    class UserClass
    {
        private string Nickname;//имя
        private DateTime last_check_date;//дата проверки(последней)
        private DateTime check_date;//произвольная дата когда пользователь чекал зрение нинаю пока куда его припхнуть, но явно понадобится для того чтобы статку чекать
        private double left_eye_vision;//зрание для левого глаза
        private double right_eye_vision;//для правого
        public UserClass(UserClass User)//конструктор
        {
            this.Nickname = User.Nickname;
            this.left_eye_vision = User.left_eye_vision;
            this.right_eye_vision = User.right_eye_vision;
            this.last_check_date = User.last_check_date;
        }
        public string Nick { get; set; }//ввести или получить имя
        public double get_last_left_eye_vision(UserClass User)//получить зрение для левого глаза для последней проверки
        {
            return User.left_eye_vision;
        }
        public double get_last_right_eye_vision(UserClass User)//получить зрение для правого последней проверки
        {
            return User.right_eye_vision;
        }
        public Tuple<double, double> get_last_vision(UserClass User)//получить зрение для обоих глаз последней проверки
        {
            var vision = new Tuple<double, double>(User.left_eye_vision, User.right_eye_vision);
            return vision;
        }
        ~UserClass() { }
        
    }
}
