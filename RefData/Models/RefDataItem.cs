using System;
namespace RefData.Models
{
    public class RefDataItem
    {
		public string TypeName { get; set; }
		public string Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public DateTime ValidFrom { get; set; }
		public DateTime ValidTo { get; set; }


        public bool IsValid
        {
            get
            {
                return this.ValidFrom <= DateTime.Now
                    && this.ValidTo >= DateTime.Now;
            }
        }

        public RefDataItem()
        {
        }
    }
}
