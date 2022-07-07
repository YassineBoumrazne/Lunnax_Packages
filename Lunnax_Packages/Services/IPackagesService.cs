using Lunnax_Packages.Models;

namespace Lunnax_Packages.Services
{
    public interface IPackagesService
    {
        public IList<PackageDto> Packages { get; set; }

        public void UpdatePackage(PackageDto package);

        public void AddPackage(PackageDto package);
        public PackageDto GetPackage(int packageId);
    }
}
