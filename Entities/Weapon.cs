using System;

namespace lrgame
{
    /// <summary>
    /// Класс содержит описание характеристик оружия
    /// </summary>
    public class Weapon : TradeItem, IStore
    {
        /// <summary>
        /// Конструктор с предустановленными значениями
        /// </summary>
        /// <param name="_damage">Повреждения</param>
        /// <param name="_damageType">Тип</param>
        /// <param name="_material">Материал</param>
        /// <param name="_actionRadius">Радиус действия</param>
        public Weapon(int _damage, string _damageType, string _material, string _actionRadius)
        {
            this.damage = _damage;
            this.damageType = _damageType;
            this.material = _material;
            this.actionRadius = _actionRadius;
        }


        private int damage;

        /// <summary>
        /// Повреждения
        /// </summary>
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        private string damageType;

        /// <summary>
        /// Тип повреждений
        /// </summary>
        public string DamageType
        {
            get
            {
                return this.damageType;
            }
            set
            {
                this.damageType = value;
            }
        }

        private string actionRadius;

        /// <summary>
        /// Радиус действия оружия
        /// </summary>
        public string ActionRadius
        {
            get
            {
                return this.actionRadius;
            }
            set
            {
                this.actionRadius = value;
            }
        }

        private string material;

        /// <summary>
        /// Материал
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

        public void Load(int objectID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
