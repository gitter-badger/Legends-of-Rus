using System;

namespace lrgame
{
    /// <summary>
    /// Класс доспехов
    /// </summary>
    public class Armor : TradeItem, IStore
    {
        #region Constructors

        /// <summary>
        /// Конструктор	класса Armor
        /// </summary>
        /// <param name="_id">ID доспеха</param>
        /// <param name="_isMale">М/Ж</param>
        /// <param name="_material">Материал</param>
        /// <param name="_strength_mod">Модификатор силы</param>
        /// <param name="_agility_mod">Модификатор ловкости</param>
        public Armor(uint _id, bool _isMale, string _material, short _strength_mod, short _agility_mod)
        {
            this.id = _id;
            this.isMale = _isMale;
            this.material = _material;
            this.strength_mod = _strength_mod;
            this.agility_mod = _agility_mod;
        }

        #endregion

        #region Properties

        private bool isMale;

        /// <summary>
        /// Принадлежность к полу (male/female)
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

        private string material;

        /// <summary>
        /// Тип брони
        /// </summary>
        public string Material
        {
            get
            {
                return this.material;
            }
            set
            {
                this.material = value;
            }
        }

        private short strength_mod;

        /// <summary>
        /// Модификатор силы
        /// </summary>
        public short Strength_mod
        {
            get
            {
                return this.strength_mod;
            }
            set
            {
                this.strength_mod = value;
            }
        }

        private short agility_mod;

        /// <summary>
        /// Модификатор ловкости
        /// </summary>
        public short Agiility_mod
        {
            get
            {
                return this.agility_mod;
            }
            set
            {
                this.agility_mod = value;
            }
        }


        #endregion

        #region Methods

        public void Load(int objectID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
