
using system;
namespace PersonalSiteMvc.Repository
{

public void Change<T>(ref T baseEntity,ref T ChangeEntity)
        {
            foreach(var item in baseEntity.GetType().GetProperties())
            {
                foreach(var changeItem in ChangeEntity.GetType().GetProperties())
                {
                    
                    if (item.Name == changeItem.Name)
                    {
                        var Baseval = item.GetValue(baseEntity);
                        var NewItem = item.GetValue(ChangeEntity);
                        changeItem.SetValue(ChangeEntity, Baseval, null);
                        item.SetValue(baseEntity, NewItem, null);
                    }
                }
            }
        }
}
