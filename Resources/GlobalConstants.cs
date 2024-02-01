namespace IronFlow.Resources
{
    public static class GlobalConstants
    {
        public const string ITSDev = "data source=EDS0451DW5SQL\\D19SO50070;database=SLA_Leap_DEV;Integrated Security=True";
        public const string ITSQA = "data source=EDS0451DW5SQL\\T19SO50082;database=SLA_Leap_QA;Integrated Security=True";
        public const string ITSStage = "data source=EDS0641QW5SQLV\\Q19SO50478;database=SLA_Leap_STGMAS;Integrated Security=True";

        public const int RoleTypeId = 1;
        public const int AppStatusTypeId = 2;

        //this is svam main token p@ssw0rd sha 256
        public const string masterToken = "A075D17F3D453073853F813838C15B8023B8C487038436354FE599C3942E1F95";
    }
}
