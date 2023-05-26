Shader "Skullgirls/UI/Palettized" {
	Properties {
		[PerRendererData] _MainTex ("Color", 2D) = "white" {}
		_PaletteTex ("Palette Texture", 2D) = "white" {}
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
		_Grayscale ("Grayscale Amount", Range(0, 1)) = 0
		_HueShiftAmount ("Hue Shift Amount", Float) = 0
		_ExtraFeatureTex ("Extra Features Texture", 2D) = "black" {}
		_ChowderEffectTex ("Chowder Effect Texture", 2D) = "black" {}
		_ChowderAnchorMode ("Chowder Anchor Mode", Float) = 0
		_ChowderPaletteIndex ("Chowder Paletrte Index", Float) = 0
		_ChowderBlendMode ("Chowder Blend Mode", Float) = 0
		_ChowderAnchorPosition ("Chowder Anchor Pos", Vector) = (0,0,0,0)
		_ChowderUIScreenAspectRatio ("Chowder Screen Size", Float) = 1
		_ShaderFeatureColumns ("Shader Feature Columns", Vector) = (0,0,0,0)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}