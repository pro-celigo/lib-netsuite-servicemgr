// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;

namespace SuiteTalk
{
    public partial class JobStatusSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<JobStatusSearchRowBasic>
    {
        public JobStatusSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public JobStatusSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new JobStatusSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<JobStatusSearchRowBasic> 
            ISearchAdvancedRow<JobStatusSearchRowBasic>.CreateBasic(Action<JobStatusSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public JobStatusSearchRow CreateBasic(Action<JobStatusSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return this;
        }

        SearchRowBasic ISearchAdvancedRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchAdvancedRow<JobStatusSearchRowBasic> 
            ISearchAdvancedRow<JobStatusSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public JobStatusSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        private static SearchRowBasic GetOrCreateJoin(JobStatusSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new JobStatusSearchRowBasic();
                    break;

                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("JobStatusSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}