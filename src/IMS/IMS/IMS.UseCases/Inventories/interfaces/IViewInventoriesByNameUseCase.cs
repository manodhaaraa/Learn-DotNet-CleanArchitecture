using IMS.CoreBussiness;

namespace IMS.UseCases.Inventories.interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}