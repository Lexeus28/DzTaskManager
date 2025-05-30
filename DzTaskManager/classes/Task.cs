using System.ComponentModel.DataAnnotations;

namespace DzTaskManager.DBclasses
{
    class Task
    {
        private Guid _task_id;
        private string _description;

        [Key]
        public Guid Task_id
        {
            get
            {
                return _task_id;
            }
            set
            {
                Task_id = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Description = value;
            }
        }
    }
}
