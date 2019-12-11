using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GoodVision
{
	class GoodVisionClass: GoodVisionInterface
	{ bool regMess;
        public GoodVisionClass() { }

        public void Add_to_file(ref UserClass User)
        {
            /*
            //добавление в файл пользователя данных
            //XML Serizalisation
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(UserClass));
            string filePath = User.Nick + ".xml";
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
                fs.Close();
                
                //Console.WriteLine("Объект сериализован");
            }
            */
            string filePath = User.Nick + ".xml";
            XDocument doc = XDocument.Load(filePath);
            XElement root = new XElement("Snippet");
            root.Add(new XAttribute("name", "name goes here"));
            root.Add(new XElement("SnippetCode", "SnippetCode"));
            doc.Element("Snippets").Add(root);
            doc.Save(filePath);
        }
        /*
        void SerializeXML(ref Users userList)
        {//List<UserClass> userList = new List<UserClass>();
            //добавление в файл пользователя данных
            //XML Serizalisation
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<UserClass>));
            string filePath = User.Nick + ".xml";
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, userList);
                //fs.Close();
                //Console.WriteLine("Объект сериализован");
            }

        }
        */
        public static bool mode;


		public void Clear_account(ref UserClass User)
		{
			try {
				File.Delete(User.Nick+".xml");
			}
			catch (FileNotFoundException)
			{
                MessageBox.Show("");
            }

		}
		

		public void Test_vision_with_circles(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Test_vision_with_letters(ref UserClass User)
		{

		}

		public void Create_account(ref UserClass User)
		{
            string filePath = User.Nick + ".xml";//можно прописать тут полный адрес
            
            try
			{
					User.File = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                //создать файл с именем;
                //закрываем поток
                System.IO.File.Create(filePath).Close();
                XDocument doc = XDocument.Load(filePath);
                XElement root = new XElement("UserData");
                doc.Add(root);
                doc.Save(filePath);
            }
			catch (FileNotFoundException)
			{
                MessageBox.Show("");
            }

			
		}
        public bool ExchangeRegMessage
        {
            get { return regMess; }
            set { regMess = value; }
        }
       

    }
}
