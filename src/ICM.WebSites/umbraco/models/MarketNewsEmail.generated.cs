//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.3.1+66434bf
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Market News Email</summary>
	[PublishedModel("marketNewsEmail")]
	public partial class MarketNewsEmail : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		public new const string ModelTypeAlias = "marketNewsEmail";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<MarketNewsEmail, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public MarketNewsEmail(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Banner: Select the main banner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("banner")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Banner => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "banner");

		///<summary>
		/// Banner URL: Enter the banner URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link BannerUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "bannerURL");

		///<summary>
		/// ECalendar URL: Enter the economic calendar URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eCalendarURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link ECalendarUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "eCalendarURL");

		///<summary>
		/// Entity: Select the entity
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("entity")]
		public virtual string Entity => this.Value<string>(_publishedValueFallback, "entity");

		///<summary>
		/// First Partner Logo: Select the first partner logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstPartnerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstPartnerLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "firstPartnerLogo");

		///<summary>
		/// First Partner URL: Enter the first partner URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstPartnerURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link FirstPartnerUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "firstPartnerURL");

		///<summary>
		/// Main Logo: Select the main logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops MainLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "mainLogo");

		///<summary>
		/// Second Partner Logo: Select the second partner logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondPartnerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondPartnerLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "secondPartnerLogo");

		///<summary>
		/// Second Partner URL: Enter the second partner URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondPartnerURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link SecondPartnerUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "secondPartnerURL");

		///<summary>
		/// Sender Email: Enter the sender email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("senderEmail")]
		public virtual string SenderEmail => this.Value<string>(_publishedValueFallback, "senderEmail");

		///<summary>
		/// Show Entity List
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.1+66434bf")]
		[ImplementPropertyType("showEntityList")]
		public virtual bool ShowEntityList => this.Value<bool>(_publishedValueFallback, "showEntityList");
	}
}
