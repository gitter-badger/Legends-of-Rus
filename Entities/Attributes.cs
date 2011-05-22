using System;
using System.Collections.Generic;
namespace lrgame
{
    /// <summary>
    /// Класс описывает дополнительные характеристики персонажа
    /// </summary>
    public class Attributes
    {
        #region Properties

        private ushort hp;

        /// <summary>
        /// Очки здоровья персонажа (минимальное значение - 1)
        /// </summary>
        public ushort HP
        {
            get
            {
                return this.hp;
            }
            set
            {
                if (value < (this.hp = 1))
                {
                    this.hp = 1;
                }
            }
        }

        private ushort tenacity;

        /// <summary>
        /// Выдержка персонажа (минимальное значение - 1)
        /// </summary>
        public ushort Tenacity
        {
            get
            {
                return this.tenacity;
            }
            set
            {
                if (value < (this.tenacity = 1))
                {
                    this.tenacity = 1;
                }
            }
        }

        private ushort energy;

        /// <summary>
        /// Запас сил персонажа (минимальное значение - 1)
        /// </summary>
        public ushort Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                if (value < (this.energy = 1))
                {
                    this.energy = 1;
                }
            }
        }

        private ushort hunger;

        /// <summary>
        /// Голод (минимальное значение - 1)
        /// </summary>
        public ushort Hunger
        {
            get
            {
                return this.hunger;
            }
            set
            {
                if (value < (this.hunger = 1))
                {
                    this.hunger = 1;
                }
            }
        }


        #endregion
    }

}