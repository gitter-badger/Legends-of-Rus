using System;
using System.Collections.Generic;
namespace lrgame
{
    /// <summary>
    /// Класс описывает структуру данных персонажа
    /// </summary>
    public class Character
    {
        #region Properties

        private byte age;

        /// <summary>
        /// Возраст персонажа
        /// </summary>
        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= (this.age = 0))
                {
                    this.age = 1;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        private bool isMale;

        /// <summary>
        /// Пол персонажа: мужской или нет?
        /// </summary>
        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        private ushort strength;

        /// <summary>
        /// Сила персонажа (минимальное значение - 1)
        /// </summary>
        public ushort Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                if (value < (this.strength = 1))
                {
                    this.strength = 1;
                }
            }
        }

        private ushort agility;

        /// <summary>
        /// Ловкость персонажа (минимальное значение - 1)
        /// </summary>
        public ushort Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                if (value < (this.agility = 1))
                {
                    this.agility = 1;
                }
            }
        }

        private ushort intelligence;

        /// <summary>
        /// Разум персонажа (минимально значение - 1)
        /// </summary>
        public ushort Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                if (value < (this.intelligence = 1))
                {
                    this.intelligence = 1;
                }
            }
        }

        private ushort stamina;

        /// <summary>
        /// Живучесть персонажа (минимальное значение - 1)
        /// </summary>
        public ushort Stamina
        {
            get
            {
                return this.stamina;
            }
            set
            {
                if (value < (this.stamina = 1))
                {
                    this.stamina = 1;
                }
            }
        }

        private ushort wisdom;

        /// <summary>
        /// Мудрость персонажа
        /// </summary>
        public ushort Wisdom
        {
            get
            {
                return this.wisdom;
            }
            set
            {
                this.wisdom = value;
            }
        }


        private ushort will;

        /// <summary>
        /// Сила воли персонажа
        /// </summary>
        public ushort Will
        {
            get
            {
                return this.will;
            }
            set
            {
                this.will = value;
            }
        }


        private ushort luck;

        /// <summary>
        /// Удача персонажа
        /// </summary>
        public ushort Luck
        {
            get
            {
                return this.luck;
            }
            set
            {
                this.luck = value;
            }
        }

        #endregion
    }

}