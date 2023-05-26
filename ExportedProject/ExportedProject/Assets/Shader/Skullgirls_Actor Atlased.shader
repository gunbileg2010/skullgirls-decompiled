Shader "Skullgirls/Actor Atlased" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_PaletteTex ("Palette Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		_LineColor ("LineTint", Vector) = (0,0,0,1)
		_HueShiftAmount ("Hue Shift Amount", Float) = 0
		_ExtraFeatureTex ("Extra Features Texture", 2D) = "black" {}
		_ChowderEffectTex ("Chowder Effect Texture", 2D) = "black" {}
		_ChowderAnchorMode ("Chowder Anchor Mode", Float) = 0
		_ChowderPaletteIndex ("Chowder Palette Index", Float) = 0
		_ChowderBlendMode ("Chowder Blend Mode", Float) = 0
		_ChowderAnchorPosition ("Chowder Anchor Pos", Vector) = (0,0,0,0)
		_Mirrored ("Mirrored", Float) = 0
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
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Skullgirls/Actor-Atlased-NoLight"
}