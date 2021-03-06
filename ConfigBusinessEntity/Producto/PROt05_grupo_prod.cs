namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt05_grupo_prod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt05_grupo_prod()
        {
            PROt06_clase_prod = new HashSet<PROt06_clase_prod>();
        }

        [Key]
        public int id_grupo_prod { get; set; }

        [StringLength(10)]
        public string cod_grupo_prod { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt06_clase_prod> PROt06_clase_prod { get; set; }
    }
}
