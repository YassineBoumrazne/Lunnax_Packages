using Lunnax_Packages.Models;

namespace Lunnax_Packages.Services
{
    public class PackagesService : IPackagesService
    {
        public IList<PackageDto> Packages { get; set; } = new List<PackageDto>()
        {
            new PackageDto(){ Display="test", Kz="test", Name="test1", Id=0},
            new PackageDto(){ Display="test", Kz="test", Name="test2", Id=1},
            new PackageDto(){ Display="test", Kz="test", Name="test2", Id=2}
        };

        public void UpdatePackage(PackageDto package)
        {
            var p = Packages.FirstOrDefault(e => e.Id == package.Id);
            p.Description = package.Description;
            p.Display = package.Display;
            p.Formula = package.Formula;
            p.Id = package.Id;
            p.InvoicePosition = package.InvoicePosition;
            p.ItemId = package.ItemId;
            p.Kz = package.Kz;
            p.Name = package.Name;
            p.Optional = package.Optional;
            p.PackageBookingBaseEnumId = package.PackageBookingBaseEnumId;
            p.PackageBookingMechanicEnumId = package.PackageBookingMechanicEnumId;
            p.PackageBookingRhythmEnumId = package.PackageBookingRhythmEnumId;
            p.Periods = package.Periods;
            p.Price = package.Price;
            p.PriceIsStatic = package.PriceIsStatic;
            p.ShopExtern = package.ShopExtern;
        }

        public void AddPackage(PackageDto package)
        {
            Packages.Add(package);
        }

        public PackageDto GetPackage(int packageId)
        {
            return Packages.FirstOrDefault(p => p.Id == packageId);
        }
    }
}
