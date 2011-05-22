namespace lrgame
{
    /// <summary>
    /// Класс описывает типичные значения ценных сущностей
    /// </summary>
    public class TradeItem : BaseEntity
    {
        private string descr;

        /// <summary>
        /// Описание
        /// </summary>
        public string Descr
        {
            get
            {
                return this.descr;
            }
            set
            {
                this.descr = value;
            }
        }

        private uint cost;

        /// <summary>
        /// Стоимость в гривнах серебра
        /// </summary>
        public uint Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }
        }

        private uint cost_gold;

        /// <summary>
        /// Стоимость в гривнах золота
        /// </summary>
        public uint Cost_gold
        {
            get
            {
                return this.cost_gold;
            }
            set
            {
                this.cost_gold = value;
            }
        }

        private ushort level_req;

        /// <summary>
        /// Требуемый уровень персонажа
        /// </summary>
        public ushort Level_req
        {
            get
            {
                return this.level_req;
            }
            set
            {
                this.level_req = value;
            }
        }

    }
}
