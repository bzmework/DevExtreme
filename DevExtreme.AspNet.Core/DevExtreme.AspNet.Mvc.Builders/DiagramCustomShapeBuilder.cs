using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Provide access to an array of custom shapes.</summary>
	public class DiagramCustomShapeBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DiagramCustomShapeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the shape's image can be edited.</summary>
		[Generated]
		public DiagramCustomShapeBuilder AllowEditImage(bool value)
		{
			base.Options["allowEditImage"] = value;
			return this;
		}

		/// <summary>Specifies whether the shape's image can be edited.</summary>
		[Generated]
		public DiagramCustomShapeBuilder AllowEditImage(JS value)
		{
			base.Options["allowEditImage"] = value;
			return this;
		}

		/// <summary>Specifies whether the shape's text can be edited.</summary>
		[Generated]
		public DiagramCustomShapeBuilder AllowEditText(bool value)
		{
			base.Options["allowEditText"] = value;
			return this;
		}

		/// <summary>Specifies whether the shape's text can be edited.</summary>
		[Generated]
		public DiagramCustomShapeBuilder AllowEditText(JS value)
		{
			base.Options["allowEditText"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's fractional height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageHeight(double value)
		{
			base.Options["backgroundImageHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's fractional height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageHeight(JS value)
		{
			base.Options["backgroundImageHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageLeft(double value)
		{
			base.Options["backgroundImageLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageLeft(JS value)
		{
			base.Options["backgroundImageLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageTop(double value)
		{
			base.Options["backgroundImageTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageTop(JS value)
		{
			base.Options["backgroundImageTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's URL.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageUrl(string value)
		{
			base.Options["backgroundImageUrl"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's URL.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageUrl(JS value)
		{
			base.Options["backgroundImageUrl"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's fractional width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageWidth(double value)
		{
			base.Options["backgroundImageWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape background image's fractional width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BackgroundImageWidth(JS value)
		{
			base.Options["backgroundImageWidth"] = value;
			return this;
		}

		/// <summary>Specifies the base shape type for the custom shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BaseType(DiagramShapeType value)
		{
			base.Options["baseType"] = value;
			return this;
		}

		/// <summary>Specifies the base shape type for the custom shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BaseType(string value)
		{
			base.Options["baseType"] = value;
			return this;
		}

		/// <summary>Specifies the base shape type for the custom shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder BaseType(JS value)
		{
			base.Options["baseType"] = value;
			return this;
		}

		/// <summary>Specifies a category to which the custom shape belongs.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Category(string value)
		{
			base.Options["category"] = value;
			return this;
		}

		/// <summary>Specifies a category to which the custom shape belongs.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Category(JS value)
		{
			base.Options["category"] = value;
			return this;
		}

		/// <summary>An array of the shape's connection points.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ConnectionPoints(Action<CollectionFactory<DiagramCustomShapesConnectionPointBuilder>> configurator)
		{
			Collection("connectionPoints", configurator);
			return this;
		}

		/// <summary>Specifies the initial height of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultHeight(double value)
		{
			base.Options["defaultHeight"] = value;
			return this;
		}

		/// <summary>Specifies the initial height of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultHeight(JS value)
		{
			base.Options["defaultHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's URL.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultImageUrl(string value)
		{
			base.Options["defaultImageUrl"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's URL.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultImageUrl(JS value)
		{
			base.Options["defaultImageUrl"] = value;
			return this;
		}

		/// <summary>Specifies the initial text of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultText(string value)
		{
			base.Options["defaultText"] = value;
			return this;
		}

		/// <summary>Specifies the initial text of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultText(JS value)
		{
			base.Options["defaultText"] = value;
			return this;
		}

		/// <summary>Specifies the initial width of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultWidth(double value)
		{
			base.Options["defaultWidth"] = value;
			return this;
		}

		/// <summary>Specifies the initial width of the shape.</summary>
		[Generated]
		public DiagramCustomShapeBuilder DefaultWidth(JS value)
		{
			base.Options["defaultWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's fractional height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageHeight(double value)
		{
			base.Options["imageHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's fractional height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageHeight(JS value)
		{
			base.Options["imageHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageLeft(double value)
		{
			base.Options["imageLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageLeft(JS value)
		{
			base.Options["imageLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageTop(double value)
		{
			base.Options["imageTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageTop(JS value)
		{
			base.Options["imageTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's fractional width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageWidth(double value)
		{
			base.Options["imageWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape image's fractional width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder ImageWidth(JS value)
		{
			base.Options["imageWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape text container's height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextHeight(double value)
		{
			base.Options["textHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape text container's height.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextHeight(JS value)
		{
			base.Options["textHeight"] = value;
			return this;
		}

		/// <summary>Specifies the shape text's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextLeft(double value)
		{
			base.Options["textLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape text's left offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextLeft(JS value)
		{
			base.Options["textLeft"] = value;
			return this;
		}

		/// <summary>Specifies the shape text's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextTop(double value)
		{
			base.Options["textTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape text's top offset.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextTop(JS value)
		{
			base.Options["textTop"] = value;
			return this;
		}

		/// <summary>Specifies the shape text container's width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextWidth(double value)
		{
			base.Options["textWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape text container's width.</summary>
		[Generated]
		public DiagramCustomShapeBuilder TextWidth(JS value)
		{
			base.Options["textWidth"] = value;
			return this;
		}

		/// <summary>Specifies the shape's tooltip in the toolbox panel.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the shape's tooltip in the toolbox panel.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the shape's type.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Type(string value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the shape's type.</summary>
		[Generated]
		public DiagramCustomShapeBuilder Type(JS value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
