namespace Lunnax_Packages.Models
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Kz { get; set; }
        public string? Description { get; set; }
        public string? Display { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public bool PriceIsStatic { get; set; }
        public int InvoicePosition { get; set; } = 1;
        public string? Formula { get; set; }
        public int PackageBookingBaseEnumId { get; set; }
        public int PackageBookingMechanicEnumId { get; set; }
        public int PackageBookingRhythmEnumId { get; set; }
        public bool Optional { get; set; }
        public bool ShopExtern { get; set; }
        public List<PeriodDto>? Periods { get; set; }=new List<PeriodDto>(){ };

    }
}
