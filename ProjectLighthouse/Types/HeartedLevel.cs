using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLighthouse.Types {
    public class HeartedLevel {
        [Key] public int HeartedLevelId { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))] public User User { get; set; }

        public int SlotId { get; set; }

        [ForeignKey(nameof(SlotId))] public Slot Slot { get; set; }
    }
}