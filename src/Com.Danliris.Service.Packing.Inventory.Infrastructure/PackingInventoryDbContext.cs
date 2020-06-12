using Com.Danliris.Service.Packing.Inventory.Data;
using Com.Danliris.Service.Packing.Inventory.Data.Models;
using Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovement;
using Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl;
using Com.Danliris.Service.Packing.Inventory.Data.Models.MaterialDeliveryNote;
using Com.Danliris.Service.Packing.Inventory.Data.Models.MaterialDeliveryNoteWeaving;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.CoverLetter;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.GarmentPackingList;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.GarmentShippingInstruction;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.GarmentShippingInvoice;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.LetterOfCredit;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Garmentshipping.ShippingNote;
using Com.Danliris.Service.Packing.Inventory.Data.Models.Product;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.CoverLetter;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.GarmentInvoice;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.GarmentPackingList;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.GarmentShippingInstruction;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.LetterOfCredit;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.GarmentShipping.ShippingNote;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.Product;
using Com.Moonlay.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.EntityConfigurations.MaterialDeliveryNoteWeaving;

namespace Com.Danliris.Service.Packing.Inventory.Infrastructure
{
    public class PackingInventoryDbContext : StandardDbContext
    {
        public PackingInventoryDbContext(DbContextOptions<PackingInventoryDbContext> options) : base(options)
        {
        }

        public DbSet<InventoryDocumentPackingItemModel> InventoryDocumentPackingItems { get; set; }
        public DbSet<InventoryDocumentPackingModel> InventoryDocumentPackings { get; set; }
        public DbSet<InventoryDocumentSKUItemModel> InventoryDocumentSKUItems { get; set; }
        public DbSet<InventoryDocumentSKUModel> InventoryDocumentSKUs { get; set; }
        public DbSet<ProductSKUModel> ProductSKUs { get; set; }
        public DbSet<ProductPackingModel> ProductPackings { get; set; }
        public DbSet<DyeingPrintingAreaInputModel> DyeingPrintingAreaInputs { get; set; }
        public DbSet<DyeingPrintingAreaInputProductionOrderModel> DyeingPrintingAreaInputProductionOrders { get; set; }
        public DbSet<DyeingPrintingAreaOutputModel> DyeingPrintingAreaOutputs { get; set; }
        public DbSet<DyeingPrintingAreaOutputProductionOrderModel> DyeingPrintingAreaOutputProductionOrders { get; set; }
        //public DbSet<DyeingPrintingAreaOutputAvalItemModel> DyeingPrintingAreaOutputAvalItems { get; set; }
        public DbSet<DyeingPrintingAreaMovementModel> DyeingPrintingAreaMovements { get; set; }
        public DbSet<DyeingPrintingAreaSummaryModel> DyeingPrintingAreaSummaries { get; set; }
        public DbSet<FabricQualityControlModel> NewFabricQualityControls { get; set; }
        public DbSet<FabricGradeTestModel> NewFabricGradeTests { get; set; }
        public DbSet<CriteriaModel> NewCriterias { get; set; }

        public DbSet<ProductModel> IPProducts { get; set; }
        public DbSet<CategoryModel> IPCategories { get; set; }
        public DbSet<PackingModel> IPPackings { get; set; }
        public DbSet<UnitOfMeasurementModel> IPUnitOfMeasurements { get; set; }

        public DbSet<PackagingStockModel> PackagingStock { get; set; }

        public DbSet<MaterialDeliveryNoteModel> MaterialDeliveryNote { get; set; }
        public DbSet<ItemsModel> Items { get; set; }

        public DbSet<MaterialDeliveryNoteWeavingModel> MaterialDeliveryNoteWeaving { get; set; }
        public DbSet<ItemsMaterialDeliveryNoteWeavingModel> ItemsMaterialDeliveryNoteWeaving { get; set; }

        public DbSet<GarmentPackingListModel> GarmentPackingLists { get; set; }
        public DbSet<GarmentPackingListItemModel> GarmentPackingListItems { get; set; }
        public DbSet<GarmentPackingListDetailModel> GarmentPackingListDetails { get; set; }
        public DbSet<GarmentPackingListDetailSizeModel> GarmentPackingListDetailSizes { get; set; }
        public DbSet<GarmentPackingListMeasurementModel> GarmentPackingListMeasurements { get; set; }
        public DbSet<GarmentShippingCoverLetterModel> GarmentShippingCoverLetters { get; set; }

        public DbSet<GarmentShippingInstructionModel> GarmentShippingInstructions { get; set; }
        public DbSet<GarmentShippingLetterOfCreditModel> GarmentShippingLetterOfCredits { get; set; }
        public DbSet<GarmentShippingNoteModel> GarmentShippingNotes { get; set; }
        public DbSet<GarmentShippingNoteItemModel> GarmentShippingNoteItems { get; set; }


		public DbSet<GarmentShippingInvoiceModel> GarmentShippingInvoices { get; set; }
		public DbSet<GarmentShippingInvoiceItemModel> GarmentShippingInvoiceItems { get; set; }
		public DbSet<GarmentShippingInvoiceAdjustmentModel> GarmentShippingInvoiceAdjustments { get; set; }
		
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InventoryDocumentPackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryDocumentPackingItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryDocumentSKUEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryDocumentSKUItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSKUEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FabricQualityControlEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FabricGradeTestEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CriteriaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaInputEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaInputProductionOrderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaOutputEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaOutputProductionOrderEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new DyeingPrintingAreaOutputAvalItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaMovementEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DyeingPrintingAreaSummaryEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UOMEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PackingEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new PackagingStockEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new GarmentPackingListEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentPackingListItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentPackingListDetailEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentPackingListDetailSizeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentPackingListMeasurementEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new GarmentShippingInstructionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentCoverLetterEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentLetterOfCreditEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GarmentShippingNoteConfig());
            modelBuilder.ApplyConfiguration(new GarmentShippingNoteItemConfig());

            modelBuilder.ApplyConfiguration(new MaterialDeliveryNoteWeavingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemsMaterialDeliveryNoteWeavingEntityTypeConfiguration());
			modelBuilder.ApplyConfiguration(new GarmentShippingInvoiceEntityTypeConfiguration());
			modelBuilder.ApplyConfiguration(new GarmentShippingInvoiceItemEntityTypeConfiguration());
			modelBuilder.ApplyConfiguration(new GarmentShippingInvoiceAdjustmentTypeConfiguration());

			modelBuilder.Entity<InventoryDocumentPackingItemModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<InventoryDocumentPackingModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<InventoryDocumentSKUItemModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<InventoryDocumentSKUModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<ProductSKUModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<ProductPackingModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<FabricQualityControlModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<FabricGradeTestModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaInputModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaInputProductionOrderModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaOutputModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaOutputProductionOrderModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaMovementModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<DyeingPrintingAreaSummaryModel>().HasQueryFilter(entity => !entity.IsDeleted);
            //modelBuilder.Entity<DyeingPrintingAreaOutputAvalItemModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<CategoryModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<ProductModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<PackingModel>().HasQueryFilter(entity => !entity.IsDeleted);
            modelBuilder.Entity<UnitOfMeasurementModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<PackagingStockModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<MaterialDeliveryNoteModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<ItemsModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<MaterialDeliveryNoteWeavingModel>().HasQueryFilter(entity => !entity.IsDeleted);

            modelBuilder.Entity<ItemsMaterialDeliveryNoteWeavingModel>().HasQueryFilter(entity => !entity.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }
    }
}