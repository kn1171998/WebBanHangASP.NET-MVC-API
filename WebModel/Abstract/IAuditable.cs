using System;


namespace WebModel.Abstract
{
    public interface IAuditable
    {

        DateTime? CreatedDate { get; set; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { set; get; }
        bool Status { set; get; }
    }
}
