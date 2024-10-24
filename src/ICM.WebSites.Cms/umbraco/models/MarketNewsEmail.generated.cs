//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.2.2+79d241a
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		public new const string ModelTypeAlias = "marketNewsEmail";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
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
		/// Banner: Enter the banner properties
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("banner")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListItem<global::Umbraco.Cms.Web.Common.PublishedModels.Banner> Banner => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListItem<global::Umbraco.Cms.Web.Common.PublishedModels.Banner>>(_publishedValueFallback, "banner");

		///<summary>
		/// Economic Calendar URL: Enter the calendar URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("calendarURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link CalendarUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "calendarURL");

		///<summary>
		/// Disclaimer: Enter the disclamer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("disclaimer")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Disclaimer => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "disclaimer");

		///<summary>
		/// Entity: Select the entity
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("entity")]
		public virtual string Entity => this.Value<string>(_publishedValueFallback, "entity");

		///<summary>
		/// Evening Email Subject: Enter the evening email Subject
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eveningEmailSubject")]
		public virtual string EveningEmailSubject => this.Value<string>(_publishedValueFallback, "eveningEmailSubject");

		///<summary>
		/// Footer Image: Select a footer image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerImage");

		///<summary>
		/// Morning Email Subject: Enter the morning email Subject
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("morningEmailSubject")]
		public virtual string MorningEmailSubject => this.Value<string>(_publishedValueFallback, "morningEmailSubject");

		///<summary>
		/// Partners: Select partners
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partners")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Partners => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "partners");

		///<summary>
		/// Regulation URL: Enter the regulation URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("regulationURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link RegulationUrl => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "regulationURL");

		///<summary>
		/// Sender Email: Enter the sender email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("senderEmail")]
		public virtual string SenderEmail => this.Value<string>(_publishedValueFallback, "senderEmail");

		///<summary>
		/// Show Entity List
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[ImplementPropertyType("showEntityList")]
		public virtual bool ShowEntityList => this.Value<bool>(_publishedValueFallback, "showEntityList");

		///<summary>
		/// T&Cs Marker: Enter the marker for Terms & Conditions
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.2.2+79d241a")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tcMarker")]
		public virtual string TcMarker => this.Value<string>(_publishedValueFallback, "tcMarker");
	}
}
