using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
{
    class UserClass
    {
        private string Nickname;
        private DateTime last_check_date;
        private double left_eye_vision;
        private double right_eye_vision;
        public UserClass(UserClass User)
        {
            this.Nickname = User.Nickname;
            this.left_eye_vision = User.left_eye_vision;
            this.right_eye_vision = User.right_eye_vision;
            this.last_check_date = User.last_check_date;
        }
        public string Nick { get; set; }
        public double get_left_eye_vision(UserClass User)
        {
            return User.left_eye_vision;
        }
        public double get_right_eye_vision(UserClass User)
        {
            return User.right_eye_vision;
        }
        public Tuple<double, double> get_vision(UserClass User)
        {
            var vision = new Tuple<double, double>(User.left_eye_vision, User.right_eye_vision);

            return vision;
        }
    }
}
