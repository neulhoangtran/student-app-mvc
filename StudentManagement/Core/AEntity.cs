using System;

namespace StudentManagement.Core
{
    public abstract class AEntity: IEntity
    {
        public int? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public void Save() {
            if (CreatedAt == null) {
                CreatedAt = DateTime.Now;
            }
            CreatedAt = DateTime.Now;
            // do anything before save
            BeforeSave();
            // executing save
            if (!Id.HasValue || Id == 0)
            {
                Create();
            } else {
                Update();
            }
            // do anything after saved
            AfterSave();
        }
        public void Delete() {
            BeforeDelete();
            ExecuteDelete();
            AfterDelete();
        }

        public virtual void Create() { }
        public virtual void Update() { }
        public virtual void BeforeSave() { }
        public virtual void AfterSave() { }
        public virtual void BeforeDelete() { }
        public virtual void AfterDelete() { }
        public virtual void ExecuteDelete() { }
        
    }
}
