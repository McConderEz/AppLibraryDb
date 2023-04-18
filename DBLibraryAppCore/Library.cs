using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DBLibraryAppCore
{
    public class Library
    {

        //TODO:План
        //4)Доработать редактирование данных о книге(сделано) 
        //2)Регистрация пользователей(сделано)  

        //1)Создать хранение пдф/ворд файлов каждой книги                    
        //5)Чтение книг в приложении
        //6)Разработка граф. интерфейса

        //7)Сортировка книг по жанрам, автору, количеству страниц, оценке читателей
        //3)Оценка книг и добавление в избранное


        public int BookCount { get => new ApplicationContext().books.Count(); }

        public Library() { }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("1)Добавить книгу в БД\n2)Посмотреть список книг\n3)Удалить книгу по Id\n4)Изменить данные о книге\n15)Очистить экран");
                int key = ReadInteger();

                switch (key)
                {
                    case 1:
                        AddBookInDb();
                        break;
                    case 2:
                        ShowBookList();
                        break;
                    case 3:
                        DeleteBookFromDb();
                        break;
                    case 4:
                        Edit();
                        break;
                    case 15:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Данной функции не существует(пока)");
                        break;
                }

            }
        }

        /// <summary>
        /// Создание и добавление книги в Бд
        /// </summary>
        /// <returns></returns>
        public virtual void AddBookInDb()
        {
            try
            {
                Console.WriteLine("Введите название книги: ");
                string title = Console.ReadLine();
                Console.WriteLine("Введите имя автора: ");
                string author = Console.ReadLine();
                Console.WriteLine("Введите описание книги(по желанию): ");
                string description = Console.ReadLine();
                Console.WriteLine("Введите жанр книги: ");
                string genre = Console.ReadLine();
                Console.WriteLine("Введите количество страниц в книге: ");
                int pagesCount = ReadIntegerPagesCount();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(genre))
                {
                    throw new ArgumentNullException("Поля не были заполнены!");
                }                

                using (var db = new ApplicationContext())
                {
                    db.Add(new Book
                    {
                        Title = title,
                        Author = author,
                        Description = "\n" + description,
                        Genre = genre,
                        PagesCount = pagesCount
                    });                    
                    db.SaveChanges();
                    Console.WriteLine("Книга была добавлена!");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        public virtual Book EditParamOfBook()
        {
            Console.WriteLine("Введите название книги: ");
            string title = Console.ReadLine();
            Console.WriteLine("Введите имя автора: ");
            string author = Console.ReadLine();
            Console.WriteLine("Введите описание книги(по желанию): ");
            string description = Console.ReadLine();
            Console.WriteLine("Введите жанр книги: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Введите количество страниц в книге: ");
            int pagesCount = ReadIntegerPagesCount();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(genre))
            {
                throw new ArgumentNullException("Поля не были заполнены!");
            }

            
            return new Book { Author = author, Description = description, Genre = genre, Title = title, PagesCount = pagesCount };
        }

        /// <summary>
        /// Вывод списка книг из Бд в консоль
        /// </summary>
        public virtual void ShowBookList()
        {
            using(var db = new ApplicationContext())
            {
                var books = db.books.ToList();
                
                if(books.Count == 0)
                {
                    Console.WriteLine("Список книг пуст...");
                    return;
                }

                int i = 1;
                foreach (var book in books)
                {
                    Console.WriteLine($"{i++}) {book.Title} - {book.Author}, {book.Genre}, {book.PagesCount} стр.,\nОписание:{book.Description}\n");
                }
            }
        }

        /// <summary>
        /// Удаление книг из Бд по id
        /// </summary>
        public virtual void DeleteBookFromDb()
        {
            Console.WriteLine("Введите id книги: ");
            int id = ReadInteger();

            using(var db = new ApplicationContext())
            {
                List<Book> books = db.books.ToList();

                if(books.Count != 0 && id > 0 && id <= books.Count)
                {
                    db.Remove(books[id-1]);
                    db.SaveChanges();
                    Console.WriteLine("Книга успешно удалена из БД!");
                }
                else
                {
                    Console.WriteLine("БД пуста, либо id выходит за границы!");
                    return;
                }
            }

        }
      
        /// <summary>
        /// Редактирование книг в БД по id 
        /// </summary>
        public virtual void Edit()
        {
            Console.WriteLine("Введите id книги для редактирования: ");
            int id = ReadInteger();

            using (var db = new ApplicationContext())
            {
                

                if (db.books.Count() != 0 && id > 0 && id <= db.books.Count())
                {

                    Book? book = db.books.ToArray()[id - 1];

                    if(book != null)
                    {
                        Console.WriteLine("Введите название книги: ");
                        book.Title = Console.ReadLine();
                        Console.WriteLine("Введите имя автора: ");
                        book.Author = Console.ReadLine();
                        Console.WriteLine("Введите описание книги(по желанию): ");
                        book.Description = Console.ReadLine();
                        Console.WriteLine("Введите жанр книги: ");
                        book.Genre = Console.ReadLine();
                        Console.WriteLine("Введите количество страниц в книге: ");
                        book.PagesCount = ReadIntegerPagesCount();
                        db.Update(book);
                        db.SaveChanges();
                        Console.WriteLine("Данные о книге успешно изменены!");
                    }
                }
                else
                {
                    Console.WriteLine("БД пуста, либо id выходит за границы!");
                    return;
                }
            }
        }

        public static int ReadInteger()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Введите целочисленное значение:");
            }
            return result;
        }

        public static int ReadIntegerPagesCount()
        {
            int result = 0;

            while(!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Введите целочисленное количество страниц(>0):");
            }
            return result;
        }

    }
}
