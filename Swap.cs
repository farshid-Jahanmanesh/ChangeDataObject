namespace SwapData
{
    public class Swap
    {
        public void Change<T>(ref T baseEntity, ref T ChangeEntity)
        {
            foreach (var BaseItem in baseEntity.GetType().GetProperties())
            {
                foreach (var changeItem in ChangeEntity.GetType().GetProperties())
                {

                    if (BaseItem.Name == changeItem.Name)
                    {
                        var Baseval = BaseItem.GetValue(baseEntity);
                        var NewItem = BaseItem.GetValue(ChangeEntity);
                        changeItem.SetValue(ChangeEntity, Baseval, null);
                        BaseItem.SetValue(baseEntity, NewItem, null);
                    }
                }
            }
        }
    }
}
