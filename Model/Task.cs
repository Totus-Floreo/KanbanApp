namespace KanbanApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int taskID { get; set; }

        public int kanbanID { get; set; }

        public int statusID { get; set; }

        public int toolID { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public virtual Kanban Kanban { get; set; }

        public virtual Status Status { get; set; }

        public virtual Tool Tool { get; set; }
    }
}
