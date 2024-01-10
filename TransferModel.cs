namespace IronFlow
{
    public class TransferModel
    {
     
        public int AppId { get; set; }

        public bool Isindividual { get; set; }
        public bool IsAssociates { get; set; }
        public bool isAll { get; set; }

        //transfering to: 
        public int TaskId { get; set; }
        public string? TaskStatus { get; set; }
        public int AppStatusId { get; set; }
        public string? WorkflowItemType { get; set; }
        public int RoleId { get; set; }
        public bool? IsTimer { get; set; }
        public string? EndTime { get; set; }
        public bool isOnlyEndTime { get; set; }
    }
}
