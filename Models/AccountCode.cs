namespace Models
{
	public class AccountCode : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccountCode>
		{
			public Configuration() : base()
			{
				HasOptional(current => current.Parent)
					.WithMany(accountCode => accountCode.Children)
					.HasForeignKey(current => current.ParentId)
					.WillCascadeOnDelete(false);
			}
		}
		#endregion /Configuration

		public AccountCode() : base()
		{
		}

		// **********
		// **********
		// **********
		public AccountCode Parent { get; set; }
		// **********

		// **********
		public System.Guid? ParentId { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		public int Code { get; set; }
		// **********

		// **********
		public int Level { get; set; }
		// **********

		// **********
		public string Path { get; set; }
		// **********

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<AccountCode> Children { get; set; }
		// **********
	}
}
