using System;
namespace StudentManagement.Core
{
    public interface IEntity
    {
        int? Id { get; set; }
        DateTime? CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }

        void Save();
        void Delete();

    }
}
