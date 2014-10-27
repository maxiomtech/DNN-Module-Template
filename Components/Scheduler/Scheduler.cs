using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Scheduling;

namespace CompanyName.ModuleName.Components.Scheduler
{
    public class Scheduler : SchedulerClient
    {


        public Scheduler(ScheduleHistoryItem oItem)
            : base()
        {
            this.ScheduleHistoryItem = oItem;
        }

        public Scheduler()
        {

        }

        public override void DoWork()
        {

            try
            {

                this.Progressing();
                this.ScheduleHistoryItem.Succeeded = true;
            }
            catch (Exception ex)
            {
                this.ScheduleHistoryItem.Succeeded = false;
                this.ScheduleHistoryItem.AddLogNote("Exception= " + ex.ToString());
                this.Errored(ref ex);
                Exceptions.LogException(ex);
            }


        }




        public static void AddScheduleTask()
        {
            ScheduleItem oItem = SchedulingProvider.Instance().GetSchedule(typeof(Scheduler).Assembly.FullName, "");
            if (oItem == null)
            {
                oItem = new ScheduleItem();
                oItem.CatchUpEnabled = false;
                oItem.Enabled = true;
                oItem.FriendlyName = "ModuleTemplate.Scheduler";
                oItem.NextStart = DateTime.Now.AddMinutes(4);
                oItem.RetainHistoryNum = 60;
                oItem.RetryTimeLapse = 30;
                oItem.RetryTimeLapseMeasurement = "m";
                oItem.ScheduleSource = ScheduleSource.NOT_SET;
                oItem.TimeLapse = 60;
                oItem.TimeLapseMeasurement = "m";
                oItem.TypeFullName = typeof(Scheduler).Assembly.FullName;
                SchedulingProvider.Instance().AddSchedule(oItem);
            }
        }

        public static bool ScheduleTaskStatus()
        {
            ScheduleItem oItem = SchedulingProvider.Instance().GetSchedule(typeof(Scheduler).Assembly.FullName, "");
            if (oItem == null)
            {
                return false;
            }
            return true;
        }

        public static void RunSchedule()
        {
            ScheduleItem oItem = SchedulingProvider.Instance().GetSchedule(typeof(Scheduler).Assembly.FullName, "");

            SchedulingProvider.Instance().RunScheduleItemNow(oItem);
            if (SchedulingProvider.SchedulerMode == SchedulerMode.TIMER_METHOD)
            {
                SchedulingProvider.Instance().ReStart("Change made to schedule.");
            }


        }
    }
}