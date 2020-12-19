namespace Agendador
{
    public enum EditMode : byte
    {
        None = 0,
        CanAdd = 1,
        CanDelete = 2,
        CanEdit = 4,
        CanSave = 8,
        IsAdding = 16,
        IsEditing = 32,
    }
}