using System;

namespace lrgame
{
    /// <summary>
    /// Класс описывает пользователя
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Имя пользователя (Максимум 60 символов)
        /// </summary>
        public override string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 60)
                {
                    throw new ApplicationException("Имя и фамилия не могут быть длиннее 60 символов");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        private uint grivna;

        /// <summary>
        /// Количество гривен
        /// </summary>
        public uint Grivna
        {
            get
            {
                return this.grivna;
            }
            set
            {
                this.grivna = value;
            }
        }

        private uint grivnaGold;

        /// <summary>
        /// Количество гривен золота
        /// </summary>
        public uint GrivnaGold
        {
            get
            {
                return this.grivnaGold;
            }
            set
            {
                this.grivnaGold = value;
            }
        }

        /// <summary>
        /// Экземпляр класса Character для дальнейшего использования в игре
        /// </summary>
        protected Character player = new Character();

        /// <summary>
        /// Игрок
        /// </summary>
        public Character Player
        {
            get
            {
                return this.player;
            }
            set
            {
                this.player = value;
            }
        }

    }
}
