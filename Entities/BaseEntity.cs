namespace lrgame
{
    /// <summary>
    /// Класс описывает свойства базовых сущностей
    /// </summary>
    public class BaseEntity
    {
        protected uint id = 0;

        /// <summary>
        /// ID
        /// </summary>
        public uint ID
        {
            get
            {
                return this.id;
            }
        }

        protected string name;

        /// <summary>
        /// Название
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}