Shader "Skullgirls/Ramp Specular" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_Fresnel ("Fresnel Color", Vector) = (1,1,1,1)
		_EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_Shininess ("Shininess", Range(0, 128)) = 48
		_FresnelRange ("Fresnel Range", Range(0, 1)) = 0.5
		_FresnelBrightness ("Fresnel Brightness (HDR)", Range(0, 10)) = 1
		_SpecularBrightness ("Specular Brightness (HDR)", Range(0, 10)) = 1
		_EmissionBrightness ("Emission Brightness (HDR)", Range(0, 10)) = 1
		_MainTex ("Main (RGBA)", 2D) = "gray" {}
		_SpecMap ("Specular", 2D) = "black" {}
		_Gloss ("Gloss", 2D) = "black" {}
		_BumpMap ("Normal", 2D) = "bump" {}
		_Emission ("Emission", 2D) = "black" {}
		_Ramp ("Ramp (RGBA)", 2D) = "white" {}
		[Toggle(COLORMULT_MAP)] _UseColorMultMap ("Use Color Mult Override Map", Float) = 0
		_ColorMultMap ("Color Mult Map", 2D) = "gray" {}
		_MultMapColorLow ("Low Mask Value Color (black)", Vector) = (1,1,1,1)
		_MultMapColorHigh ("High Mask Value Color (white)", Vector) = (1,1,1,1)
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
	Fallback "Specular"
}