using System.ComponentModel.DataAnnotations;

namespace TaskSystem.Data.Enums
{
    public enum Status 
    {
        [Display(Name="Staged")]
        Staged,
        [Display(Name="InProgress")]
        InProgress,
        [Display(Name="Complete")]
        Complete
    }
}
