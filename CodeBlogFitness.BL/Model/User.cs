using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeBlogFitness.BL.Model
{/// <summary>
/// Пользователь.
/// </summary>
    public class User
    {
        #region   Cвойства.
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес.
        /// </summary>

         public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
         
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя. </param>
        /// <param name="gender">Пол.
        /// </param>
        /// <param name="birthDate">Дата рождения.
        /// </param>
        /// <param name="weight">Вес.
        /// </param>
        /// <param name="height">Рост.
        /// </param>
        public User(string name, 
            Gender gender,
            DateTime birthDate,
            double weight, 
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }
            if(Gender==null)
            {
                throw new ArgumentNullException("пол не может быть пустым или null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") ||birthDate>=DateTime.Now)
            {
                throw new ArgumentException(" не может быть пустым или null", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentException(" не может быть пустым или null", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException(" не может быть пустым или null", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
