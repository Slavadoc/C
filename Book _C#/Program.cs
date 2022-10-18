// БД
using System;
using System.Windows.Forms;
using System.Data;
// Пространство имен для работы с базами данных SQL Server
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
class DataInOutGrid : Form
{
    SqlDataAdapter dataAdapter;
    DataGridView dataGridView;

    public DataInOutGrid()
    {
        //Изменяем размеры формы
        this.Width = 450;
        this.Height = 400;

        // Указываем заголовок окна
        this.Text = "Двустороннее связывание:" +
            " база данных и элемент Grid.";
        // Добавляем элементы управления - 
        //метку, таблицу и командную кнопку
        Label labelCaption = new Label();
        labelCaption.Text = "Планеты!";
        labelCaption.Location = new Point(60, 10);
        labelCaption.Width = 200;
        labelCaption.Parent = this;

        // Добавляем элемент DataGridView на форму

        dataGridView = new DataGridView();
        dataGridView.Width = 350;
        dataGridView.Height = 250;
        dataGridView.Location = new Point(20, 50);
        dataGridView.AutoResizeColumns();
        this.Controls.Add(dataGridView);

        // Добавляем командную кнопку
        Button buttonSave = new Button();
        buttonSave.Location = new Point(100, 320);
        buttonSave.Width = 220;
        buttonSave.Text = "Сохранить изменения в базе данных!";
        buttonSave.Click += 
            new System.EventHandler(ButtonSave_Click);
        buttonSave.Parent = this;

        // Формируем запрос к базе данных - 
        //запрашиваем информацию о планетах
        string sql = "SELECT * FROM PLANET";
        string connectionString;
        // DataTable сохраняет данные в памяти как таблицу
        DataTable dataTable = new DataTable();
        /*
        //Вариант 1
        // Подключаемся к базе данных SQL Server Express Edition
        
        // Указываем физический путь к базе данных PLANETS
        string dbLocation = 
        ("../../../databases/planets.mdf");

        connectionString = @"data source=.\SQLEXPRESS;" +
              "User Instance=true;Integrated Security=SSPI;" +
          "AttachDBFilename=" + dbLocation;
        SqlConnection connection = new SqlConnection(connectionString);
       */

        //Вариант 2
        // Подключаемся к базе данных SQL Server 2005
        connectionString =
            "data source = localhost; Initial Catalog = Planets;" +
             "Integrated Security = SSPI";
        SqlConnection connection = new SqlConnection(connectionString);

        //Открываем соединение
        connection.Open();

        //Создаем команду 
        SqlCommand sqlCommand = new SqlCommand(sql, connection);
        //Создаем адаптер
        // DataAdapter - посредник между базой данных и DataSet
        dataAdapter = new SqlDataAdapter(sqlCommand);

        //Создаем построитель команд
        //Для адаптера становится доступной команда Update 
        SqlCommandBuilder commandBuilder =
            new SqlCommandBuilder(dataAdapter);
        
        // Данные из адаптера поступают в DataTable 
        dataAdapter.Fill(dataTable);
        // Связываем данные с элементом DataGridView
        dataGridView.DataSource = dataTable;
        // Очистка
        connection.Close();
    }   

       
    static void Main()
    {
        // Создаем и запускаем форму 
        Application.Run(new DataInOutGrid());
    }
    
    void ButtonSave_Click(object sender, System.EventArgs args)
    {
        try
        {
            dataAdapter.Update((DataTable)dataGridView.DataSource);
            MessageBox.Show("Изменения в базе данных выполнены!",
                "Уведомление о результатах", MessageBoxButtons.OK);
        }
        catch(Exception)
        {
            MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                            "Уведомление о результатах", MessageBoxButtons.OK);
        }
    }
} 



// // Консольное приложение 
// using System;
// class WriteAFewLines{
//   static void Main(){
//     Console.WriteLine("Введите ваше любимое слово : ");
//     string favoritedWord = Console.ReadLine();
//     Console.WriteLine("Сколько раз его напечать ?");
//     int numberOfTimes = Convert.ToInt32(Console.ReadLine());
//     for(int i=0; i < numberOfTimes; i++){
//       Console.WriteLine(favoritedWord);
//     }
//   }
// }
//V1  using System;
// class PleaseSayUra{
//   static void Main(){
//     Console.Write("Ура!!!");
//     Console.ReadLine();
//   }
// }

// Guitaris g = new Guitaris();
// g.name = "Kipelov";
// g.age = 28;
// g.canSing = false;
// g.guitarType = "Acoustic";
// g.guitarBrand = "Gibson";
// Console.Write(g.name);
// Console.WriteLine(g.age);
// Console.WriteLine(g.canSing);
// Console.WriteLine(g.guitarType);
// Console.WriteLine(g.guitarBrand);

// public class Musician {
//   public string name;
//   public int age;
//   public bool canSing;
// }
// public class Guitaris : Musician {
//   public string guitarType;
//   public string guitarBrand;
// }
//Наследование 
// Bird b = new Bird();
// b.kindOfAnimal = "Орел";
// b.isMammal = false;
// b.featherColor = "Black";
// Console.Write(b.kindOfAnimal);
// class Animal
// {
//     public string kindOfAnimal;
//     public string name;
//     public int numberOfLegs;
//     public int height;
//     public int length;
//     public string color;
//     bool hasTail;
//     protected bool isMammal;
//     private bool spelingCorrect;
//      static void Main(){}
//     public void print(){
//       Console.WriteLine("Animal");
//     }
// }

// class Bird : Animal {// Потомок от животного 
//   public string featherColor;
// }
// using Charly.SchoolUtilites;

// Animal cat = new Animal();

// // Charly.SchoolUtilites.Animal cat;
// // cat = new Charly.SchoolUtilites.Animal();

// namespace Charly.SchoolUtilites{
//   class Animal {

//   }
// }
// using System;
// using System.Windows.Forms;
//
// class MyButtonClass: Form {
//     private Button mrButton;
//     public MyButtonClass()// Метод-конструктор
//       {
//         mrButton = new Button();
//         mrButton.Text = "Нажми меня";
//         this.Controls.Add(mrButton);
//       }
//
//       static void Main()// Основной метод
//         {
//           Application.Run(new MyButtonClass());
//         }
// }

// using System;
// using System.Windows.Forms;
//
// class MyButtonClass: Forms{
//   private Button mrButton;
//   public MyButtonClass(){
//     mrButton = new Button();
//     mrButton.Text = "Click my";
//     this.Controls.Add(mrButton);
//   }
//   static void Main(){
//       Application.Run(new MyButtonClass());
//   }
// }

// Person p = new Person();
// //string Slava = "Slava";
// //string Doc = "Doc";
// Person ps = new Person("Slava","Doc");
// Console.WriteLine(p.lastName);
// class Person{
//   public string firstName;
//   public string lastName;
//
//   public Person(){
//     firstName = "Johnnu";
//     lastName = "Rocket";
//   }
//   public Person(string firstName, string lastName){
//     firstName = this.firstName;
//     lastName = this.lastName;
//   }
  //public static void Main(){}
//}
// int i;
// i = NumberOfLegs(“индейка”);
// Console.WriteLine(“У индейки конечностей – “ + i);
// i = NumberOfLegs(“обезьяна”);
// Console.WriteLine(“У обезьяны конечностей – “ + i);
//
// class Animal {
//
//     int numberOfLegs(string Animal){
//         if(Animal == "Слон"){
//             return 4;
//         } if(Animal == "Индейка"){
//             return 2;
//         } if(Animal == "Устрица"){
//             return 1;
//         } else {
//             return 0;
//         }
//     }
//     static void Main(){}
// }
// Методы
// Person Petr = new Person();
// string firstName = "Petr";
// string lastName = "Ivanov";
// Petr.ShowFullName(firstName,lastName);
// Person Slava = new Person();
// string name = Console.ReadLine();
// Slava.SayHello(name);
// class Person
// {
//     public string firstName;
//     public string lastName;
//     public string name;
//     public void ShowFullName(string firstName, string lastName){ //методс параметром
//       Console.WriteLine("Name is " + firstName + " " + lastName);
//     }
//     public void SayHello(string name) {
//         Console.WriteLine("Hello " + name + " !");
//     }
// }

// class Animal
// {
//     public string kindOfAnimal;
//     public string name;
//     public int numberOfLegs;
//     public int height;
//     public int length;
//     public string color;
//     bool hasTail;
//     protected bool isMammal;
//     private bool spelingCorrect;
//      static void Main(){}
//     public void print(){
//       Console.WriteLine("Animal");
//     }
// }
//
// class Zoo
// {
//   Animal a = new Animal();
//   a.kindOfAnimal = "Kangaroo";
//   a.isMammal = false;
//   a.spelingCorrectt =true;
// }

// Animal Barsik = new Animal();
// Barsik.print();
// Barsik.kindOfAnimal = "Cat";
// Barsik.name = "Barsik";
// Barsik.numberOfLegs = 4;
// Barsik.height = 50;
// Barsik.length = 110;
// Barsik.color = "Black";
// Barsik.hasTail = true;
// Barsik.isMammal = true;

// class MyTestClass
// {
//   static void Main(){
//     Animal myAnimal;
//   }
//
// }
// Console.WriteLine("Введите сокрость ракеты на момент выхода за пределы атмосферы земли");
//             double rocketSpeed = Convert.ToDouble(Console.ReadLine());
//             //string speed = Console.ReadLine();
//             //double rocketSpeed =  Convert.ToDouble(speed);
//             Console.WriteLine(rocketSpeed );
//             if (rocketSpeed < 7.5)
//             {
//                 Console.WriteLine(" The Rocket will fall down. Back to earth!");
//             }
//             if (rocketSpeed < 11.2 & rocketSpeed >= 7.5)
//             {
//                 Console.WriteLine(" The Rocket will remain on the orbit");
//
//             }
//             else if (rocketSpeed < 16.4 & rocketSpeed >= 11.2 )
//             {
//                 Console.WriteLine(" The Rocket will travel to the space but not far. The sun gravity is still here");
//             }
//             else if (rocketSpeed >= 16.4 )
//             {
//                 Console.WriteLine(" Woo-hoo! let's travel around the space");
//             }
//             Console.WriteLine("what's wrong");
//             Console.ReadKey();
