Shader "UI/UI-Omni" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		[Toggle(SG_UI_GRADIENTMAP)] _UseGradientMap ("Use Gradient Map", Float) = 0
		_GradientTex ("Gradient Texture", 2D) = "white" {}
		[Toggle(SG_UI_SHINE)] _UseShine ("Use Shine", Float) = 0
		_ShineIntensity ("Shine Intensity", Range(0, 1)) = 0.5
		_ShineWidth ("ShineWidth", Range(0, 1)) = 0.01
		_ShineLocation ("ShineLocation", Range(-1, 2)) = 0
		_ShineAngle ("Shine Angle", Range(0, 1)) = 1
		[Toggle] _ShineMirror ("Mirror Shine?", Float) = 0
		_GrayscaleAmount ("Grayscale Amount", Range(0, 1)) = 0
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
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
}