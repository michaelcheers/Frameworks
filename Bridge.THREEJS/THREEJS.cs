using System;
using Bridge;
using Bridge.Html5;
using Bridge.WebGL;
using any = System.Object;
using boolean = System.Boolean;
using Function = System.Delegate;
using number = System.Double;
using Number = System.Double;
using RegExp = Bridge.Text.RegularExpressions.Regex;


namespace THREE
{
    [External]
    [Name("THREE")]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static string REVISION { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CullFace CullFaceNone { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CullFace CullFaceBack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CullFace CullFaceFront { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CullFace CullFaceFrontBack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static FrontFaceDirection FrontFaceDirectionCW { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static FrontFaceDirection FrontFaceDirectionCCW { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ShadowMapType BasicShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ShadowMapType PCFShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ShadowMapType PCFSoftShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Side FrontSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Side BackSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Side DoubleSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Shading FlatShading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Shading SmoothShading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Colors NoColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Colors FaceColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending NoBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending NormalBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending AdditiveBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending SubtractiveBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending MultiplyBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Blending CustomBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingEquation AddEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingEquation SubtractEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingEquation ReverseSubtractEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingEquation MinEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingEquation MaxEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor ZeroFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor OneFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor SrcColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor OneMinusSrcColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor SrcAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor OneMinusSrcAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor DstAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingDstFactor OneMinusDstAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingSrcFactor DstColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingSrcFactor OneMinusDstColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static BlendingSrcFactor SrcAlphaSaturateFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes NeverDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes AlwaysDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes LessDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes LessEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes EqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes GreaterEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes GreaterDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static DepthModes NotEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Combine MultiplyOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Combine MixOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Combine AddOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ToneMapping NoToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ToneMapping LinearToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ToneMapping ReinhardToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ToneMapping Uncharted2ToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ToneMapping CineonToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping UVMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping CubeReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping CubeRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping EquirectangularReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping EquirectangularRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping SphericalReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping CubeUVReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Mapping CubeUVRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Wrapping RepeatWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Wrapping ClampToEdgeWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Wrapping MirroredRepeatWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter NearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter NearestMipMapNearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter NearestMipMapLinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter LinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter LinearMipMapNearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureFilter LinearMipMapLinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType UnsignedByteType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType ByteType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType ShortType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType UnsignedShortType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType IntType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType UnsignedIntType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType FloatType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureDataType HalfFloatType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelType UnsignedShort4444Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelType UnsignedShort5551Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelType UnsignedShort565Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat AlphaFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat RGBFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat RGBAFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat LuminanceFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat LuminanceAlphaFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static PixelFormat RGBEFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGB_S3TC_DXT1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT3_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT5_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGB_PVRTC_4BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGB_PVRTC_2BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGBA_PVRTC_4BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGBA_PVRTC_2BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static CompressedPixelFormat RGB_ETC1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static AnimationActionLoopStyles LoopOnce { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static AnimationActionLoopStyles LoopRepeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static AnimationActionLoopStyles LoopPingPong { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationModes InterpolateDiscrete { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationModes InterpolateLinear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationModes InterpolateSmooth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationEndingModes ZeroCurvatureEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationEndingModes ZeroSlopeEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static InterpolationEndingModes WrapAroundEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TrianglesDrawModes TrianglesDrawModesMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TrianglesDrawModes TriangleStripDrawMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TrianglesDrawModes TriangleFanDrawMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding LinearEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding SRGBEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding GammaEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding RGBEEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding LogLuvEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding RGBM7Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding RGBM16Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static TextureEncoding RGBDEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static number GeometryIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static number Object3DIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static LoadingManager DefaultLoadingManager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static number MaterialIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static LineMode LineStrip { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static LineMode LinePieces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ShaderChunkInterface ShaderChunk { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static ShaderLibInterface ShaderLib { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static UniformsLibInterface UniformsLib { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static number TextureIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Warn(any message = default(any), params any[] optionalParams);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Error(any message = default(any), params any[] optionalParams);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Log(any message = default(any), params any[] optionalParams);
#pragma warning restore CS0626
    }
    [External]
    public static class AnimationUtils
    {
#pragma warning disable CS0626
        public extern static any ArraySlice(any array, number from, number to);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any ConvertArray(any array, any type, boolean forceClone);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static boolean IsTypedArray(any @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number[] GetKeyFrameOrder(number times);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any[] SortedArray(any[] values, number stride, number[] order);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void FlattenJSON(string[] jsonKeys, any[] times, any[] values, string valuePropertyName);
#pragma warning restore CS0626
    }
    [External]
    public partial class PropertyBinding
    {
        [External]
        public class Composite
        {
#pragma warning disable CS0824
            public extern Composite(any targetGroup, any path, any parsedPath = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
            public extern any GetValue(any array, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
            public extern void SetValue(any array, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
            public extern void Bind();
#pragma warning restore CS0626
#pragma warning disable CS0626
            public extern void Unbind();
#pragma warning restore CS0626
        }

    }
    [External]
    public static class GeometryUtils
    {
#pragma warning disable CS0626
        public extern static any Merge(any goemetry1, any goemetry2, any materialIndexOffset = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any Center(any geometry);
#pragma warning restore CS0626
    }
    [External]
    public static class Cache
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static boolean Enabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static any Files { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Add(string key, any file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any Get(string key);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Remove(string key);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Clear();
#pragma warning restore CS0626
    }
    [External]
    public static class ColorKeywords
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Aliceblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Antiquewhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Aqua { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Aquamarine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Azure { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Beige { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Bisque { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Black { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Blanchedalmond { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Blue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Blueviolet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Brown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Burlywood { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Cadetblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Chartreuse { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Chocolate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Coral { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Cornflowerblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Cornsilk { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Crimson { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Cyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkcyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkgoldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkkhaki { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkmagenta { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkolivegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkorange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkorchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darksalmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkslateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkslategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkslategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Darkviolet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Deeppink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Deepskyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Dimgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Dimgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Dodgerblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Firebrick { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Floralwhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Forestgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Fuchsia { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Gainsboro { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Ghostwhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Gold { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Goldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Gray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Green { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Greenyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Grey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Honeydew { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Hotpink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Indianred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Indigo { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Ivory { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Khaki { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lavender { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lavenderblush { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lawngreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lemonchiffon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightcoral { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightcyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightgoldenrodyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightpink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightsalmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightskyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightslategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightslategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightsteelblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lightyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Lime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Limegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Linen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Magenta { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Maroon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumaquamarine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumorchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumpurple { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumslateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumspringgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mediumvioletred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Midnightblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mintcream { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Mistyrose { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Moccasin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Navajowhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Navy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Oldlace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Olive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Olivedrab { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Orange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Orangered { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Orchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Palegoldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Palegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Paleturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Palevioletred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Papayawhip { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Peachpuff { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Peru { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Pink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Plum { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Powderblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Purple { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Red { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Rosybrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Royalblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Saddlebrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Salmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Sandybrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Seagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Seashell { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Sienna { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Silver { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Skyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Slateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Slategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Slategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Snow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Springgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Steelblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Tan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Teal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Thistle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Tomato { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Turquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Violet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Wheat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number White { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Whitesmoke { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Yellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static number Yellowgreen { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public static class Math
    {
#pragma warning disable CS0626
        public extern static string GenerateUUID();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number Clamp(number value, number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number EuclideanModulo(number n, number m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number MapLinear(number x, number a1, number a2, number b1, number b2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number Smoothstep(number x, number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number Smootherstep(number x, number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number Random16();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number RandInt(number low, number high);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number RandFloat(number low, number high);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number RandFloatSpread(number range);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number DegToRad(number degrees);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number RadToDeg(number radians);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static boolean IsPowerOfTwo(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number NearestPowerOfTwo(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number NextPowerOfTwo(number value);
#pragma warning restore CS0626
    }
    [External]
    public static class UniformsUtils
    {
#pragma warning disable CS0626
        public extern static any Merge(any[] uniforms);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any Clone(any uniforms_src);
#pragma warning restore CS0626
    }
    [External]
    public static class CurveUtils
    {
#pragma warning disable CS0626
        public extern static number TangentQuadraticBezier(number t, number p0, number p1, number p2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number TangentCubicBezier(number t, number p0, number p1, number p2, number p3);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number TangentSpline(number t, number p0, number p1, number p2, number p3);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number Interpolate(number p0, number p1, number p2, number p3, number t);
#pragma warning restore CS0626
    }
    [External]
    public static class ImageUtils
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static string CrossOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Texture LoadTexture(string url, Mapping mapping = default(Mapping), loadTextureParam3Delegate onLoad = default(loadTextureParam3Delegate), loadTextureParam4Delegate onError = default(loadTextureParam4Delegate));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Texture LoadTextureCube(string[] array, Mapping mapping = default(Mapping), loadTextureCubeParam3Delegate onLoad = default(loadTextureCubeParam3Delegate), loadTextureCubeParam4Delegate onError = default(loadTextureCubeParam4Delegate));
#pragma warning restore CS0626
        [External]
        public delegate void loadTextureParam3Delegate(Texture texture);
        [External]
        public delegate void loadTextureParam4Delegate(string message);
        [External]
        public delegate void loadTextureCubeParam3Delegate(Texture texture);
        [External]
        public delegate void loadTextureCubeParam4Delegate(string message);

    }
    [External]
    public static class SceneUtils
    {
#pragma warning disable CS0626
        public extern static Object3D CreateMultiMaterialObject(Geometry geometry, Material[] materials);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Detach(Object3D child, Object3D parent, Scene scene);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Attach(Object3D child, Scene scene, Object3D parent);
#pragma warning restore CS0626
    }
    [External]
    public static class ShapeUtils
    {
#pragma warning disable CS0626
        public extern static number Area(number[] contour);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector2[][] Triangulate(Vector2[] contour, boolean indices);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector2[][] TriangulateShape(Vector2[] contour, Vector2[][] holes);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static boolean IsClockWise(number[] pts);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number B2(number t, number p0, number p1, number p2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number B3(number t, number p0, number p1, number p2, number p3);
#pragma warning restore CS0626
    }
    [External]
    public enum MOUSE
    {
        LEFT,
        MIDDLE,
        RIGHT
    }
    [External]
    public enum CullFace
    {

    }
    [External]
    public enum FrontFaceDirection
    {

    }
    [External]
    public enum ShadowMapType
    {

    }
    [External]
    public enum Side
    {

    }
    [External]
    public enum Shading
    {

    }
    [External]
    public enum Colors
    {

    }
    [External]
    public enum Blending
    {

    }
    [External]
    public enum BlendingEquation
    {

    }
    [External]
    public enum BlendingDstFactor
    {

    }
    [External]
    public enum BlendingSrcFactor
    {

    }
    [External]
    public enum DepthModes
    {

    }
    [External]
    public enum Combine
    {

    }
    [External]
    public enum ToneMapping
    {

    }
    [External]
    public enum Mapping
    {

    }
    [External]
    public enum Wrapping
    {

    }
    [External]
    public enum TextureFilter
    {

    }
    [External]
    public enum TextureDataType
    {

    }
    [External]
    public enum PixelType
    {

    }
    [External]
    public enum PixelFormat
    {

    }
    [External]
    public enum CompressedPixelFormat
    {

    }
    [External]
    public enum AnimationActionLoopStyles
    {

    }
    [External]
    public enum InterpolationModes
    {

    }
    [External]
    public enum InterpolationEndingModes
    {

    }
    [External]
    public enum TrianglesDrawModes
    {

    }
    [External]
    public enum TextureEncoding
    {

    }
    [External]
    public class AnimationClip
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern KeyframeTrack[] Tracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Results { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AnimationClip(string name = default(string), number duration = default(number), KeyframeTrack[] tracks = default(KeyframeTrack[]));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void ResetDuration();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationClip Trim();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationClip Optimize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip CreateFromMorphTargetSequence(string name, MorphTarget[] morphTargetSequence, number fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip FindByName(AnimationClip clipArray, string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip[] CreateClipsFromMorphTargetSequences(MorphTarget[] morphTargets, number fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip Parse(any json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip ParseAnimation(any animation, Bone[] bones, string nodeName);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any ToJSON();
#pragma warning restore CS0626
    }
    [External]
    public class AnimationMixer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Time { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number TimeScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AnimationMixer(any root);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any ClipAction(AnimationClip clip, any root = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ExistingAction(AnimationClip clip, any root = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationMixer StopAllAction(AnimationClip clip, any root = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationMixer Update(number deltaTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetRoot();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncacheClip(AnimationClip clip);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncacheRoot(any root);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncazcheAction(AnimationClip clip, any root = default(any));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONObjectsInterface : ObjectsInterface
    {
#pragma warning disable CS0626
        public extern number Total { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number InUse { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ObjectsInterface
    {
        [FieldProperty]
        number Total { get; set; }
        [FieldProperty]
        number InUse { get; set; }
    }
    [ObjectLiteral]
    public class JSONStatsInterface : StatsInterface
    {
#pragma warning disable CS0626
        public extern number BindingsPerObject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ObjectsInterface Objects { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface StatsInterface
    {
        [FieldProperty]
        number BindingsPerObject { get; set; }
        [FieldProperty]
        ObjectsInterface Objects { get; set; }
    }
    [External]
    public class AnimationObjectGroup
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern StatsInterface Stats { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AnimationObjectGroup(params any[] args);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(params any[] args);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Remove(params any[] args);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Uncache(params any[] args);
#pragma warning restore CS0626
    }
    [External]
    public class KeyframeTrack
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Times { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Values { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern string ValueTypeName { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern Float32Array TimeBufferType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern Float32Array ValueBufferType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern InterpolationModes DefaultInterpolation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern KeyframeTrack(string name, any[] times, any[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern DiscreteInterpolant InterpolantFactoryMethodDiscrete(any result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LinearInterpolant InterpolantFactoryMethodLinear(any result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern CubicInterpolant InterpolantFactoryMethodSmooth(any result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetInterpolation(InterpolationModes interpolation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterpolationModes GetInterpolation();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetValuesize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Shift(number timeOffset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Scale(number timeScale);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Trim(number startTime, number endTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Validate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Optimize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static KeyframeTrack Parse(any json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any ToJSON(KeyframeTrack track);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONBindingTypeInterface : BindingTypeInterface
    {
        [External]
        public delegate number BindingTypeInterfaceIndexerDelegate(string bindingType);

#pragma warning disable CS0626
        public extern number this[string bindingType] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BindingTypeInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface BindingTypeInterface
    {
        number this[string bindingType] { get; set; }
    }
    [ObjectLiteral]
    public class JSONVersioningInterface : VersioningInterface
    {
        [External]
        public delegate number VersioningInterfaceIndexerDelegate(string versioning);

#pragma warning disable CS0626
        public extern number this[string versioning] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern VersioningInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface VersioningInterface
    {
        number this[string versioning] { get; set; }
    }
    [External]
    public partial class PropertyBinding
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ParsedPath { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Node { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any RootNode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern BindingTypeInterface BindingType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern VersioningInterface Versioning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern Function[] GetterByBindingType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern Function[][] SetterByBindingTypeAndVersioning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PropertyBinding(any rootNode, string path, any parsedPath = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any GetValue(any targetArray, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetValue(any sourceArray, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Bind();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Unbind();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static PropertyBinding Create(any root, any path, any parsedPath = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any ParseTrackName(string trackName);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static any FindNode(any root, string nodeName);
#pragma warning restore CS0626
    }
    [External]
    public class PropertyMixer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Binding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ValueSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Buffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number CumulativeWeight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number UseCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ReferenceCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PropertyMixer(any binding, string typeName, number valueSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Accumulate(number accuIndex, number weight);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Apply(number accuIndex);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SaveOriginalState();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RestoreOriginalState();
#pragma warning restore CS0626
    }
    [External]
    public class BooleanKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern BooleanKeyframeTrack(string name, any[] times, any[] values);
#pragma warning restore CS0824
    }
    [External]
    public class NumberKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern NumberKeyframeTrack(string name, any[] times, any[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class QuaternionKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern QuaternionKeyframeTrack(string name, any[] times, any[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class StringKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern StringKeyframeTrack(string name, any[] times, any[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class VectorKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern VectorKeyframeTrack(string name, any[] times, any[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class Camera : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 MatrixWorldInverse { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 ProjectionMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Camera();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 GetWorldDirection(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LookAt(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Camera Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Camera Copy(Camera camera = default(Camera));
#pragma warning restore CS0626
    }
    [External]
    public class CubeCamera : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLRenderTargetCube RenderTarget { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubeCamera(number near = default(number), number far = default(number), number cubeResolution = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void UpdateCubeMap(Renderer renderer, Scene scene);
#pragma warning restore CS0626
    }
    [External]
    public class OrthographicCamera : Camera
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Zoom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Left { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Right { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Top { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Bottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern OrthographicCamera(number left, number right, number top, number bottom, number near = default(number), number far = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void UpdateProjectionMatrix();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern OrthographicCamera Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern OrthographicCamera Copy(OrthographicCamera source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta = default(any));
#pragma warning restore CS0626
    }
    [External]
    public class PerspectiveCamera : Camera
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number FocalLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Zoom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Fov { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Aspect { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PerspectiveCamera(number fov = default(number), number aspect = default(number), number near = default(number), number far = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetLens(number focalLength, number frameHeight = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetViewOffset(number fullWidth, number fullHeight, number x, number y, number width, number height);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateProjectionMatrix();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PerspectiveCamera Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PerspectiveCamera Copy(PerspectiveCamera source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta = default(any));
#pragma warning restore CS0626
    }
    [External]
    public class StereoCamera : Camera
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Aspect { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern PerspectiveCamera CameraL { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern PerspectiveCamera CameraR { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern StereoCamera();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update(PerspectiveCamera camera);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONUpdateRangeInterface : UpdateRangeInterface
    {
#pragma warning disable CS0626
        public extern number Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Count { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface UpdateRangeInterface
    {
        [FieldProperty]
        number Offset { get; set; }
        [FieldProperty]
        number Count { get; set; }
    }
    [ObjectLiteral]
    public class JSONcolorsInterface : colorsInterface
    {
#pragma warning disable CS0626
        public extern number R { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number G { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number B { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface colorsInterface
    {
        [FieldProperty]
        number R { get; set; }
        [FieldProperty]
        number G { get; set; }
        [FieldProperty]
        number B { get; set; }
    }
    [ObjectLiteral]
    public class JSONindicesInterface : indicesInterface
    {
#pragma warning disable CS0626
        public extern number A { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number C { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface indicesInterface
    {
        [FieldProperty]
        number A { get; set; }
        [FieldProperty]
        number B { get; set; }
        [FieldProperty]
        number C { get; set; }
    }
    [ObjectLiteral]
    public class JSONvectorsInterface : vectorsInterface
    {
#pragma warning disable CS0626
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Y { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface vectorsInterface
    {
        [FieldProperty]
        number X { get; set; }
        [FieldProperty]
        number Y { get; set; }
    }
    [External]
    public class BufferAttribute
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ArrayLike<number> Array { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ItemSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern UpdateRangeInterface UpdateRange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BufferAttribute(ArrayLike<number> array, number itemSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern BufferAttribute SetDynamic(boolean dynamic);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Copy(BufferAttribute source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute CopyAt(number index1, BufferAttribute attribute, number index2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute CopyArray(ArrayLike<number> array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Set(ArrayLike<number> value, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetX(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetX(number index, number x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetY(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetY(number index, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetZ(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetZ(number index, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetW(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetW(number index, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXY(number index, number x, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXYZ(number index, number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXYZW(number index, number x, number y, number z, number w);
#pragma warning restore CS0626
    }
    [External]
    public class Int8Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int8Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint8Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint8Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint8ClampedAttribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint8ClampedAttribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Int16Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int16Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint16Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint16Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Int32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int32Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint32Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Float32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Float32Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Float64Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Float64Attribute(any array, number itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class DynamicBufferAttribute : BufferAttribute
    {
#pragma warning disable CS0824
        extern DynamicBufferAttribute();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONGroupsInterface : GroupsInterface
    {
#pragma warning disable CS0626
        public extern number Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number MaterialIndex { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GroupsInterface
    {
        [FieldProperty]
        number Start { get; set; }
        [FieldProperty]
        number Count { get; set; }
        [FieldProperty]
        number MaterialIndex { get; set; }
    }
    [ObjectLiteral]
    public class JSONDrawRangeInterface : DrawRangeInterface
    {
#pragma warning disable CS0626
        public extern number Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Count { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DrawRangeInterface
    {
        [FieldProperty]
        number Start { get; set; }
        [FieldProperty]
        number Count { get; set; }
    }
    [External]
    public delegate void addEventListenerParam2Delegate(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate(Event @event);
    [ObjectLiteral]
    public class JSONeventInterface : eventInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate any eventInterfaceIndexerDelegate(string attachment);

#pragma warning disable CS0626
        public extern any this[string attachment] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern eventInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface eventInterface
    {
        [FieldProperty]
        string Type { get; set; }
        any this[string attachment] { get; set; }
    }
    [External]
    public class BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static number MaxIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BufferAttribute Index { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Any<BufferAttribute, InterleavedBufferAttribute[]> Attributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MorphAttributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Drawcalls { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Offsets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern GroupsInterface Groups { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Box3 BoundingBox { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BoundingSphere BoundingSphere { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern DrawRangeInterface DrawRange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BufferGeometry();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern BufferAttribute GetIndex();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetIndex(BufferAttribute index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry AddAttribute(string name, Any<BufferAttribute, InterleavedBufferAttribute> attribute);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute GetAttribute(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RemoveAttribute(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddGroup(number start, number count, number materialIndex = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearGroups();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDrawRange(number start, number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry ApplyMatrix(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateX(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateY(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateZ(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Translate(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Scale(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LookAt(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Center();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFromObject(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateFromObject(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry FromGeometry(Geometry geometry, any settings = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry FromDirectGeometry(DirectGeometry geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeBoundingBox();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeBoundingSphere();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeVertexNormals();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Merge(BufferGeometry geometry, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void NormalizeNormals();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry ToNonIndexed();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Copy(BufferGeometry source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddIndex(any index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any AddAttribute(any name, any array, any itemSize);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddDrawCall(any start, any count, any indexOffset = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearDrawCalls();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeFaceNormals();
#pragma warning restore CS0626
    }
    [External]
    public class Clock
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number StartTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number OldTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ElapsedTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Running { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Clock(boolean autoStart = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Start();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Stop();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetElapsedTime();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetDelta();
#pragma warning restore CS0626
    }
    [External]
    public class DirectGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] Indices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Vertices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Normals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color[] Colors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2[] Uvs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2[] Uvs2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern GroupsInterface Groups { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern MorphTarget[] MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] SkinWeights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] SkinIndices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Box3 BoundingBox { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BoundingSphere BoundingSphere { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean VerticesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NormalsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ColorsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean UvsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean GroupsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DirectGeometry();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void ComputeBoundingBox();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeBoundingSphere();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeGroups(Geometry geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DirectGeometry FromGeometry(Geometry geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate listener);
#pragma warning restore CS0626
    }
    [External]
    public delegate void addEventListenerParam2Delegate1(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate1(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate1(Event @event);
    [External]
    public class EventDispatcher
    {
#pragma warning disable CS0824
        public extern EventDispatcher();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Apply(any @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate1 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate1 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate1 listener);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONEvent : Event
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Target { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Event
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any Target { get; set; }
    }
    [External]
    public class Face3
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number A { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number C { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Normal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] VertexNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color[] VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MaterialIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Face3(number a, number b, number c, Vector3 normal = default(Vector3), Color color = default(Color), number materialIndex = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(number a, number b, number c, Vector3 normal = default(Vector3), Color[] vertexColors = default(Color[]), number materialIndex = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(number a, number b, number c, Vector3[] vertexNormals = default(Vector3[]), Color color = default(Color), number materialIndex = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(number a, number b, number c, Vector3[] vertexNormals = default(Vector3[]), Color[] vertexColors = default(Color[]), number materialIndex = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Face3 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Face3 Copy(Face3 source);
#pragma warning restore CS0626
    }
    [External]
    public class Face4 : Face3
    {
#pragma warning disable CS0824
        extern Face4();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONMorphTarget : MorphTarget
    {
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3[] Vertices { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MorphTarget
    {
        [FieldProperty]
        string Name { get; set; }
        [FieldProperty]
        Vector3[] Vertices { get; set; }
    }
    [ObjectLiteral]
    public class JSONMorphColor : MorphColor
    {
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color[] Colors { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MorphColor
    {
        [FieldProperty]
        string Name { get; set; }
        [FieldProperty]
        Color[] Colors { get; set; }
    }
    [ObjectLiteral]
    public class JSONMorphNormals : MorphNormals
    {
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3[] Normals { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MorphNormals
    {
        [FieldProperty]
        string Name { get; set; }
        [FieldProperty]
        Vector3[] Normals { get; set; }
    }
    [ObjectLiteral]
    public class JSONBoundingSphere : BoundingSphere
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface BoundingSphere
    {
        [FieldProperty]
        number Radius { get; set; }
    }
    [External]
    public delegate void addEventListenerParam2Delegate2(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate2(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate2(Event @event);
    [External]
    public class Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Vertices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color[] Colors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Face3[] Faces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2[][][] FaceVertexUvs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern MorphTarget[] MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern MorphNormals[] MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] SkinWeights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] SkinIndices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number[] LineDistances { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Box3 BoundingBox { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BoundingSphere BoundingSphere { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean VerticesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ElementsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean UvsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NormalsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ColorsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean LineDistancesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean GroupsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Bone[] Bones { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern AnimationClip Animation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern AnimationClip[] Animations { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Geometry();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Geometry ApplyMatrix(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry RotateX(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry RotateY(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry RotateZ(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Translate(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Scale(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LookAt(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry FromBufferGeometry(BufferGeometry geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Center();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeFaceNormals();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeVertexNormals(boolean areaWeighted = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeMorphNormals();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeLineDistances();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeBoundingBox();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ComputeBoundingSphere();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Merge(Geometry geometry, Matrix matrix, number materialIndexOffset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void MergeMesh(Mesh mesh);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number MergeVertices();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SortFacesByMaterialIndex();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Copy(Geometry source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate2 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate2 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate2 listener);
#pragma warning restore CS0626
    }
    [External]
    public class InstancedBufferAttribute : BufferAttribute
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MeshPerAttribute { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedBufferAttribute(ArrayLike<number> data, number itemSize, number meshPerAttribute = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern InstancedBufferAttribute Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InstancedBufferAttribute Copy(InstancedBufferAttribute source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONGroupsInterface1 : GroupsInterface1
    {
#pragma warning disable CS0626
        public extern number Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Instances { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GroupsInterface1
    {
        [FieldProperty]
        number Start { get; set; }
        [FieldProperty]
        number Count { get; set; }
        [FieldProperty]
        number Instances { get; set; }
    }
    [External]
    public class InstancedBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern GroupsInterface1 Groups { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MaxInstancedCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedBufferGeometry();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddGroup(number start, number count, number instances);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InstancedBufferGeometry Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InstancedBufferGeometry Copy(InstancedBufferGeometry source);
#pragma warning restore CS0626
    }
    [External]
    public class InterleavedBuffer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ArrayLike<number> Array { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Stride { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern UpdateRangeInterface UpdateRange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InterleavedBuffer(ArrayLike<number> array, number stride);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern InterleavedBuffer SetDynamic(boolean dynamic);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Copy(InterleavedBuffer source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer CopyAt(number index1, InterleavedBufferAttribute attribute, number index2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Set(ArrayLike<number> value, number index);
#pragma warning restore CS0626
    }
    [External]
    public class InstancedInterleavedBuffer : InterleavedBuffer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MeshPerAttribute { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedInterleavedBuffer(ArrayLike<number> array, number stride, number meshPerAttribute = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern InstancedInterleavedBuffer Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InstancedInterleavedBuffer Copy(InstancedInterleavedBuffer source);
#pragma warning restore CS0626
    }
    [External]
    public class InterleavedBufferAttribute
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern InterleavedBuffer Data { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ItemSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InterleavedBufferAttribute(InterleavedBuffer interleavedBuffer, number itemSize, number offset);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern number GetX(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetX(number index, number x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetY(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetY(number index, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetZ(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetZ(number index, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetW(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetW(number index, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXY(number index, number x, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXYZ(number index, number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXYZW(number index, number x, number y, number z, number w);
#pragma warning restore CS0626
    }
    [External]
    public delegate any traverseParam1Delegate(Object3D @object);
    [External]
    public delegate any traverseVisibleParam1Delegate(Object3D @object);
    [External]
    public delegate any traverseAncestorsParam1Delegate(Object3D @object);
    [ObjectLiteral]
    public class JSONmetaInterface : metaInterface
    {
#pragma warning disable CS0626
        public extern any Geometries { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Materials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Textures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Images { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface metaInterface
    {
        [FieldProperty]
        any Geometries { get; set; }
        [FieldProperty]
        any Materials { get; set; }
        [FieldProperty]
        any Textures { get; set; }
        [FieldProperty]
        any Images { get; set; }
    }
    [External]
    public delegate void addEventListenerParam2Delegate3(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate3(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate3(Event @event);
    [External]
    public class Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Parent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D[] Children { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Up { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Position { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Euler Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string EulerOrder { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Quaternion Quaternion { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 ModelViewMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix3 NormalMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean RotationAutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 Matrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 MatrixWorld { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MatrixAutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MatrixWorldNeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Layers Layers { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean CastShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ReceiveShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean FrustumCulled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number RenderOrder { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any UserData { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static Vector3 DefaultUp { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static boolean DefaultMatrixAutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Object3D();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void ApplyMatrix(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRotationFromAxisAngle(Vector3 axis, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRotationFromEuler(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRotationFromMatrix(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRotationFromQuaternion(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateOnAxis(Vector3 axis, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateX(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateY(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateZ(number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateOnAxis(Vector3 axis, number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Translate(number distance, Vector3 axis);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateX(number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateY(number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateZ(number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 LocalToWorld(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 WorldToLocal(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LookAt(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Add(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Remove(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetObjectById(number id);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetObjectByName(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetObjectByProperty(string name, string value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetWorldPosition(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion GetWorldQuaternion(Quaternion optionalTarget = default(Quaternion));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler GetWorldRotation(Euler optionalTarget = default(Euler));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetWorldScale(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetWorldDirection(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Traverse(traverseParam1Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TraverseVisible(traverseVisibleParam1Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TraverseAncestors(traverseAncestorsParam1Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMatrix();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMatrixWorld(boolean force);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Copy(Object3D source, boolean recursive = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetChildByName(string name);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONIntersection : Intersection
    {
#pragma warning disable CS0626
        public extern number Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToRay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Point { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Index { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Face3 Face { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number FaceIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Object { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Intersection
    {
        [FieldProperty]
        number Distance { get; set; }
        [FieldProperty]
        number DistanceToRay { get; set; }
        [FieldProperty]
        Vector3 Point { get; set; }
        [FieldProperty]
        number Index { get; set; }
        [FieldProperty]
        Face3 Face { get; set; }
        [FieldProperty]
        number FaceIndex { get; set; }
        [FieldProperty]
        Object3D Object { get; set; }
    }
    [ObjectLiteral]
    public class JSONPointsInterface : PointsInterface
    {
#pragma warning disable CS0626
        public extern number Threshold { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointsInterface
    {
        [FieldProperty]
        number Threshold { get; set; }
    }
    [ObjectLiteral]
    public class JSONRaycasterParameters : RaycasterParameters
    {
#pragma warning disable CS0626
        public extern any Mesh { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Line { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any LOD { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointsInterface Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Sprite { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface RaycasterParameters
    {
        [FieldProperty]
        [Name(false)]
        any Mesh { get; set; }
        [FieldProperty]
        [Name(false)]
        any Line { get; set; }
        [FieldProperty]
        [Name(false)]
        any LOD { get; set; }
        [FieldProperty]
        [Name(false)]
        PointsInterface Points { get; set; }
        [FieldProperty]
        [Name(false)]
        any Sprite { get; set; }
    }
    [External]
    public class Raycaster
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Ray Ray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern RaycasterParameters Params { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number LinePrecision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Raycaster(Vector3 origin = default(Vector3), Vector3 direction = default(Vector3), number near = default(number), number far = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(Vector3 origin, Vector3 direction);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFromCamera(coordsInterface coords, Camera camera);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Intersection[] IntersectObject(Object3D @object, boolean recursive = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Intersection[] IntersectObjects(Object3D[] objects, boolean recursive = default(boolean));
#pragma warning restore CS0626
    }

    [External]
    public interface coordsInterface
    {
        [FieldProperty]
        int X { get; set; }
        [FieldProperty]
        int Y { get; set; }
    }

    [ObjectLiteral]
    public class JSONcoordsInterface : coordsInterface
    {
#pragma warning disable CS0626
        public extern int X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern int Y { get; set; }
#pragma warning restore CS0626
    }

    [External]
    public class Layers
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Mask { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Layers();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(number channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Enable(number channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Toggle(number channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Disable(number channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Test(Layers layers);
#pragma warning restore CS0626
    }
    [External]
    public class Font
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Data { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Font(any data);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any[] GenerateShapes(string text, number size, number divisions);
#pragma warning restore CS0626
    }
    [External]
    public class Light : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ReceiveShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraFov { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraLeft { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraRight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraNear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowCameraFar { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowMapWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ShadowMapHeight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Light(Any<number, string> hex = default(Any<number, string>), number intensity = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Light Copy(Light source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Light Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class LightShadow
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Camera Camera { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Bias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 MapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern RenderTarget Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 Matrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LightShadow(Camera camera);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern LightShadow Copy(LightShadow source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LightShadow Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class AmbientLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean CastShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AmbientLight(Any<number, string> hex = default(Any<number, string>), number intensity = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern AmbientLight Copy(AmbientLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AmbientLight Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class DirectionalLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Target { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DirectionalLight(Any<number, string> hex = default(Any<number, string>), number intensity = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern DirectionalLight Copy(DirectionalLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HemisphereLight Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class HemisphereLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color GroundColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern HemisphereLight(Any<number, string> skyColorHex = default(Any<number, string>), Any<number, string> groundColorHex = default(Any<number, string>), number intensity = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern HemisphereLight Copy(HemisphereLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HemisphereLight Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class PointLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Decay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Power { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PointLight(Any<number, string> hex = default(Any<number, string>), number intensity = default(number), number distance = default(number), number decay = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern PointLight Copy(PointLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointLight Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [External]
    public class SpotLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Target { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Angle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Exponent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Decay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Power { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SpotLight(Any<number, string> hex = default(Any<number, string>), number intensity = default(number), number distance = default(number), number angle = default(number), number exponent = default(number), number decay = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern SpotLight Clone(boolean recursive = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SpotLight Copy(PointLight source);
#pragma warning restore CS0626
    }
    [External]
    public delegate void onLoadStartDelegate();
    [External]
    public delegate void onLoadProgressDelegate();
    [External]
    public delegate void onLoadCompleteDelegate();
    [External]
    public class Loader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern onLoadStartDelegate OnLoadStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onLoadProgressDelegate OnLoadProgress { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onLoadCompleteDelegate OnLoadComplete { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string CrossOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static LoaderHandler Handlers { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Loader();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern string ExtractUrlBase(string url);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material[] InitMaterials(Material[] materials, string texturePath);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean CreateMaterial(Material m, string texturePath, string crossOrigin = default(string));
#pragma warning restore CS0626
    }
    [External]
    public delegate object handlersDelegate(Loader RegExp);
    [ObjectLiteral]
    public class JSONLoaderHandler : LoaderHandler
    {
#pragma warning disable CS0626
        public extern handlersDelegate[] Handlers { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate void addDelegate(RegExp regex, Loader loader);

#pragma warning disable CS0626
        public extern void Add(RegExp regex, Loader loader);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern addDelegate add { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Loader getDelegate(string file);

#pragma warning disable CS0626
        public extern Loader Get(string file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern getDelegate get { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LoaderHandler
    {
        [FieldProperty]
        handlersDelegate[] Handlers { get; set; }
        void Add(RegExp regex, Loader loader);
        Loader Get(string file);
    }
    [External]
    public delegate void loadParam2Delegate(string responseText);
    [External]
    public delegate void loadParam3Delegate(any @event);
    [External]
    public delegate void loadParam4Delegate(any @event);
    [External]
    public class XHRLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string ResponseType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean WithCredentials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern XHRLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Load(string url, loadParam2Delegate onLoad = default(loadParam2Delegate), loadParam3Delegate onProgress = default(loadParam3Delegate), loadParam4Delegate onError = default(loadParam4Delegate));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetResponseType(string responseType);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetWithCredentials(boolean withCredentials);
#pragma warning restore CS0626
    }
    [External]
    public class FontLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern FontLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate onLoad = default(loadParam2Delegate), loadParam3Delegate onProgress = default(loadParam3Delegate), loadParam4Delegate onError = default(loadParam4Delegate));
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate1(HTMLImageElement image);
    [External]
    public delegate void loadParam3Delegate1(any @event);
    [External]
    public delegate void loadParam4Delegate1(any @event);
    [External]
    public class ImageLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string CrossOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ImageLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern HTMLImageElement Load(string url, loadParam2Delegate1 onLoad = default(loadParam2Delegate1), loadParam3Delegate1 onProgress = default(loadParam3Delegate1), loadParam4Delegate1 onError = default(loadParam4Delegate1));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(any value);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate2(Geometry geometry, Material[] materials);
    [External]
    public delegate void loadParam3Delegate2(any @event);
    [External]
    public delegate void loadParam4Delegate2(any @event);
    [ObjectLiteral]
    public class JSONParseInterface : ParseInterface
    {
#pragma warning disable CS0626
        public extern Geometry Geometry { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material[] Materials { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParseInterface
    {
        [FieldProperty]
        Geometry Geometry { get; set; }
        [FieldProperty]
        Material[] Materials { get; set; }
    }
    [External]
    public class JSONLoader : Loader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean WithCredentials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern HTMLElement StatusDomElement { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern JSONLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate2 onLoad = default(loadParam2Delegate2), loadParam3Delegate2 onProgress = default(loadParam3Delegate2), loadParam4Delegate2 onError = default(loadParam4Delegate2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexturePath(string value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ParseInterface Parse(any json, string texturePath = default(string));
#pragma warning restore CS0626
    }
    [External]
    public delegate void constructorParam1Delegate();
    [External]
    public delegate void constructorParam2Delegate(string url, number loaded, number total);
    [External]
    public delegate void constructorParam3Delegate();
    [External]
    public delegate void onStartDelegate();
    [External]
    public delegate void onLoadDelegate();
    [External]
    public delegate void onProgressDelegate(any item, number loaded, number total);
    [External]
    public delegate void onErrorDelegate();
    [External]
    public class LoadingManager
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern onStartDelegate OnStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onLoadDelegate OnLoad { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onProgressDelegate OnProgress { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onErrorDelegate OnError { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LoadingManager(constructorParam1Delegate onLoad = default(constructorParam1Delegate), constructorParam2Delegate onProgress = default(constructorParam2Delegate), constructorParam3Delegate onError = default(constructorParam3Delegate));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void ItemStart(string url);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ItemEnd(string url);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ItemError(string url);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate3(BufferGeometry bufferGeometry);
    [External]
    public delegate void loadParam3Delegate3(any @event);
    [External]
    public delegate void loadParam4Delegate3(any @event);
    [External]
    public class BufferGeometryLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BufferGeometryLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate3 onLoad, loadParam3Delegate3 onProgress = default(loadParam3Delegate3), loadParam4Delegate3 onError = default(loadParam4Delegate3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Parse(any json);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONTexturesInterface : TexturesInterface
    {
        [External]
        public delegate Texture TexturesInterfaceIndexerDelegate(string key);

#pragma warning disable CS0626
        public extern Texture this[string key] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern TexturesInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface TexturesInterface
    {
        Texture this[string key] { get; set; }
    }
    [External]
    public delegate void loadParam2Delegate4(Material material);
    [ObjectLiteral]
    public class JSONtexturesInterface : texturesInterface
    {
        [External]
        public delegate Texture texturesInterfaceIndexerDelegate(string key);

#pragma warning disable CS0626
        public extern Texture this[string key] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern texturesInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface texturesInterface
    {
        Texture this[string key] { get; set; }
    }
    [External]
    public class MaterialLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TexturesInterface Textures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MaterialLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate4 onLoad);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture GetTexture(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material Parse(any json);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate5(Object3D @object);
    [External]
    public delegate void parseTParam2Delegate(Object3D @object);
    [External]
    public delegate void parseImagesParam2Delegate();
    [External]
    public class ObjectLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string TexturePass { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string CrossOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ObjectLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate5 onLoad = default(loadParam2Delegate5));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexturePath(string value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T Parse<T>(any json, parseTParam2Delegate onLoad = default(parseTParam2Delegate)) where T : Object3D;
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] ParseGeometries(any json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material[] ParseMaterials(any json, Texture[] textures);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationClip[] ParseAnimations(any json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] ParseImages(any json, parseImagesParam2Delegate onLoad);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture[] ParseTextures(any json, any images);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T ParseObject<T>(any data, any[] geometries, Material[] materials) where T : Object3D;
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate6(Texture texture);
    [External]
    public class TextureLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string CrossOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TextureLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Texture Load(string url, loadParam2Delegate6 onLoad = default(loadParam2Delegate6));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate7(CubeTexture texture);
    [External]
    public delegate void loadParam3Delegate4(any @event);
    [External]
    public delegate void loadParam4Delegate4(any @event);
    [External]
    public class CubeTextureLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string CorssOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubeTextureLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string[] urls, loadParam2Delegate7 onLoad = default(loadParam2Delegate7), loadParam3Delegate4 onProgress = default(loadParam3Delegate4), loadParam4Delegate4 onError = default(loadParam4Delegate4));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam2Delegate8(DataTexture dataTexture);
    [External]
    public delegate void loadParam3Delegate5(any @event);
    [External]
    public delegate void loadParam4Delegate5(any @event);
    [External]
    public class BinaryTextureLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BinaryTextureLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate8 onLoad, loadParam3Delegate5 onProgress = default(loadParam3Delegate5), loadParam4Delegate5 onError = default(loadParam4Delegate5));
#pragma warning restore CS0626
    }
    [External]
    public class DataTextureLoader : BinaryTextureLoader
    {
#pragma warning disable CS0824
        extern DataTextureLoader();
#pragma warning restore CS0824
    }
    [External]
    public delegate void loadParam2Delegate9(CompressedTexture texture);
    [External]
    public delegate void loadParam3Delegate6(any @event);
    [External]
    public delegate void loadParam4Delegate6(any @event);
    [External]
    public class CompressedTextureLoader
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LoadingManager Manager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CompressedTextureLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam2Delegate9 onLoad, loadParam3Delegate6 onProgress = default(loadParam3Delegate6), loadParam4Delegate6 onError = default(loadParam4Delegate6));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMaterialParameters : MaterialParameters
    {
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MaterialParameters
    {
        [FieldProperty]
        string Name { get; set; }
        [FieldProperty]
        Side Side { get; set; }
        [FieldProperty]
        number Opacity { get; set; }
        [FieldProperty]
        boolean Transparent { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        BlendingDstFactor BlendSrc { get; set; }
        [FieldProperty]
        BlendingSrcFactor BlendDst { get; set; }
        [FieldProperty]
        BlendingEquation BlendEquation { get; set; }
        [FieldProperty]
        number BlendSrcAlpha { get; set; }
        [FieldProperty]
        number BlendDstAlpha { get; set; }
        [FieldProperty]
        number BlendEquationAlpha { get; set; }
        [FieldProperty]
        DepthModes DepthFunc { get; set; }
        [FieldProperty]
        boolean DepthTest { get; set; }
        [FieldProperty]
        boolean DepthWrite { get; set; }
        [FieldProperty]
        boolean ColorWrite { get; set; }
        [FieldProperty]
        number Precision { get; set; }
        [FieldProperty]
        boolean PolygonOffset { get; set; }
        [FieldProperty]
        number PolygonOffsetFactor { get; set; }
        [FieldProperty]
        number PolygonOffsetUnits { get; set; }
        [FieldProperty]
        number AlphaTest { get; set; }
        [FieldProperty]
        boolean PremultipliedAlpha { get; set; }
        [FieldProperty]
        number Overdraw { get; set; }
        [FieldProperty]
        boolean Visible { get; set; }
    }
    [External]
    public delegate void addEventListenerParam2Delegate4(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate4(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate4(Event @event);
    [External]
    public class Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color WarpRGB { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Material();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material Copy(Material source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate4 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate4 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate4 listener);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONLineBasicMaterialParameters : LineBasicMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Linecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Linejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LineBasicMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        number Linewidth { get; set; }
        [FieldProperty]
        string Linecap { get; set; }
        [FieldProperty]
        string Linejoin { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class LineBasicMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Linecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Linejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LineBasicMaterial(LineBasicMaterialParameters parameters = default(LineBasicMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(LineBasicMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LineBasicMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LineBasicMaterial Copy(LineBasicMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONLineDashedMaterialParameters : LineDashedMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DashSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LineDashedMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        number Linewidth { get; set; }
        [FieldProperty]
        number Scale { get; set; }
        [FieldProperty]
        number DashSize { get; set; }
        [FieldProperty]
        number GapSize { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class LineDashedMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number DashSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number GapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LineDashedMaterial(LineDashedMaterialParameters parameters = default(LineDashedMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(LineDashedMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LineDashedMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LineDashedMaterial Copy(LineDashedMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshBasicMaterialParameters : MeshBasicMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshBasicMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        number Opacity { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        number AoMapIntensity { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        number Reflectivity { get; set; }
        [FieldProperty]
        number RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Skinning { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class MeshBasicMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshBasicMaterial(MeshBasicMaterialParameters parameters = default(MeshBasicMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshBasicMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshBasicMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshBasicMaterial Copy(MeshBasicMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshDepthMaterialParameters : MeshDepthMaterialParameters
    {
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshDepthMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
    }
    [External]
    public class MeshDepthMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshDepthMaterial(MeshDepthMaterialParameters parameters = default(MeshDepthMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshDepthMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshDepthMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshDepthMaterial Copy(MeshDepthMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshLambertMaterialParameters : MeshLambertMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Any<number, string> Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshLambertMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        Any<number, string> Emissive { get; set; }
        [FieldProperty]
        number EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LighhtMap { get; set; }
        [FieldProperty]
        number LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        number AoMapIntensity { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        number Reflectivity { get; set; }
        [FieldProperty]
        number RefractionRatio { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Skinning { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
        [FieldProperty]
        boolean MorphNormals { get; set; }
    }
    [External]
    public class MeshLambertMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshLambertMaterial(MeshLambertMaterialParameters parameters = default(MeshLambertMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshLambertMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshLambertMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshLambertMaterial Copy(MeshLambertMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshStandardMaterialParameters : MeshStandardMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Metalness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture RoughnessMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture MetalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshStandardMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        number Roughness { get; set; }
        [FieldProperty]
        number Metalness { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LighhtMap { get; set; }
        [FieldProperty]
        number LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        number AoMapIntensity { get; set; }
        [FieldProperty]
        Color Emissive { get; set; }
        [FieldProperty]
        number EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture BumpMap { get; set; }
        [FieldProperty]
        number BumpScale { get; set; }
        [FieldProperty]
        Texture NormalMap { get; set; }
        [FieldProperty]
        number NormalScale { get; set; }
        [FieldProperty]
        Texture DisplacementMap { get; set; }
        [FieldProperty]
        number DisplacementScale { get; set; }
        [FieldProperty]
        number DisplacementBias { get; set; }
        [FieldProperty]
        Texture RoughnessMap { get; set; }
        [FieldProperty]
        Texture MetalMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        number EnvMapIntensity { get; set; }
        [FieldProperty]
        number RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Skinning { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
        [FieldProperty]
        boolean MorphNormals { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class MeshStandardMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Metalness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number DisplacementBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture RoughnessMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture MetalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshStandardMaterial(MeshStandardMaterialParameters parameters = default(MeshStandardMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshStandardMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshStandardMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshStandardMaterial Copy(MeshStandardMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshPhysicalMaterialParameters : MeshPhysicalMaterialParameters
    {
#pragma warning disable CS0626
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ClearCoat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ClearCoatRoughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Metalness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture RoughnessMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture MetalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshPhysicalMaterialParameters : MeshStandardMaterialParameters
    {
        [FieldProperty]
        number Reflectivity { get; set; }
        [FieldProperty]
        number ClearCoat { get; set; }
        [FieldProperty]
        number ClearCoatRoughness { get; set; }
    }
    [External]
    public class MeshPhysicalMaterial : MeshStandardMaterial
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ClearCoat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ClearCoatRoughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshPhysicalMaterial(MeshPhysicalMaterialParameters parameters = default(MeshPhysicalMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshPhysicalMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshPhysicalMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshPhysicalMaterial Copy(MeshPhysicalMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshNormalMaterialParameters : MeshNormalMaterialParameters
    {
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshNormalMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
    }
    [External]
    public class MeshNormalMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshNormalMaterial(MeshNormalMaterialParameters parameters = default(MeshNormalMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshNormalMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshNormalMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshNormalMaterial Copy(MeshNormalMaterial source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMeshPhongMaterialParameters : MeshPhongMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Specular { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Shininess { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LightMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DisplacementBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshPhongMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        number Specular { get; set; }
        [FieldProperty]
        number Shininess { get; set; }
        [FieldProperty]
        number Opacity { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LightMap { get; set; }
        [FieldProperty]
        number LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        number AoMapIntensity { get; set; }
        [FieldProperty]
        number Emissive { get; set; }
        [FieldProperty]
        number EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture BumpMap { get; set; }
        [FieldProperty]
        number BumpScale { get; set; }
        [FieldProperty]
        Texture NormalMap { get; set; }
        [FieldProperty]
        Vector2 NormalScale { get; set; }
        [FieldProperty]
        Texture DisplacementMap { get; set; }
        [FieldProperty]
        number DisplacementScale { get; set; }
        [FieldProperty]
        number DisplacementBias { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        number Reflectivity { get; set; }
        [FieldProperty]
        number RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Skinning { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
        [FieldProperty]
        boolean MorphNormals { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class MeshPhongMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Specular { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Shininess { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture LightMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number DisplacementBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Combine Combine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinecap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string WireframeLinejoin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Metal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MeshPhongMaterial(MeshPhongMaterialParameters parameters = default(MeshPhongMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(MeshPhongMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshPhongMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MeshPhongMaterial Copy(MeshPhongMaterial source);
#pragma warning restore CS0626
    }
    [External]
    public class MultiMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material[] Materials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MultiMaterial(Material[] materials = default(Material[]));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any ToJSON(any meta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MultiMaterial Clone();
#pragma warning restore CS0626
    }
    [External]
    public class MeshFaceMaterial : MultiMaterial
    {
#pragma warning disable CS0824
        extern MeshFaceMaterial();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONPointsMaterialParameters : PointsMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean SizeAttenuation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointsMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        number Size { get; set; }
        [FieldProperty]
        boolean SizeAttenuation { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class PointsMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean SizeAttenuation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PointsMaterial(PointsMaterialParameters parameters = default(PointsMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(PointsMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointsMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointsMaterial Copy(PointsMaterial source);
#pragma warning restore CS0626
    }
    [External]
    public class PointCloudMaterial : PointsMaterial
    {
#pragma warning disable CS0824
        extern PointCloudMaterial();
#pragma warning restore CS0824
    }
    [External]
    public class ParticleBasicMaterial : PointsMaterial
    {
#pragma warning disable CS0824
        extern ParticleBasicMaterial();
#pragma warning restore CS0824
    }
    [External]
    public class ParticleSystemMaterial : PointsMaterial
    {
#pragma warning disable CS0824
        extern ParticleSystemMaterial();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONShaderMaterialParameters : ShaderMaterialParameters
    {
#pragma warning disable CS0626
        public extern any Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Uniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string VertexShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string FragmentShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LineWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Lights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShaderMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        any Defines { get; set; }
        [FieldProperty]
        any Uniforms { get; set; }
        [FieldProperty]
        string VertexShader { get; set; }
        [FieldProperty]
        string FragmentShader { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        number LineWidth { get; set; }
        [FieldProperty]
        boolean Wireframe { get; set; }
        [FieldProperty]
        number WireframeLinewidth { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
        [FieldProperty]
        boolean Lights { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        boolean Skinning { get; set; }
        [FieldProperty]
        boolean MorphTargets { get; set; }
        [FieldProperty]
        boolean MorphNormals { get; set; }
    }
    [ObjectLiteral]
    public class JSONExtensionsInterface : ExtensionsInterface
    {
#pragma warning disable CS0626
        public extern boolean Derivatives { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean FragDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DrawBuffers { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ShaderTextureLOD { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ExtensionsInterface
    {
        [FieldProperty]
        boolean Derivatives { get; set; }
        [FieldProperty]
        boolean FragDepth { get; set; }
        [FieldProperty]
        boolean DrawBuffers { get; set; }
        [FieldProperty]
        boolean ShaderTextureLOD { get; set; }
    }
    [External]
    public class ShaderMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Uniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string VertexShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string FragmentShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Lights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Derivatives { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ExtensionsInterface Extensions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any DefaultAttributeValues { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Index0AttributeName { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ShaderMaterial(ShaderMaterialParameters parameters = default(ShaderMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(ShaderMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShaderMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShaderMaterial Copy(ShaderMaterial source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta);
#pragma warning restore CS0626
    }
    [External]
    public class RawShaderMaterial : ShaderMaterial
    {
#pragma warning disable CS0824
        public extern RawShaderMaterial(ShaderMaterialParameters parameters = default(ShaderMaterialParameters));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONSpriteMaterialParameters : SpriteMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Transparent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingDstFactor BlendSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingSrcFactor BlendDst { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BlendingEquation BlendEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface SpriteMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        number Rotation { get; set; }
        [FieldProperty]
        boolean Fog { get; set; }
    }
    [External]
    public class SpriteMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SpriteMaterial(SpriteMaterialParameters parameters = default(SpriteMaterialParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetValues(SpriteMaterialParameters parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SpriteMaterial Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SpriteMaterial Copy(SpriteMaterial source);
#pragma warning restore CS0626
    }
    [External]
    public class Box2
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 Max { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 Min { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Box2(Vector2 min = default(Vector2), Vector2 max = default(Vector2));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Box2 Set(Vector2 min, Vector2 max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 SetFromPoints(Vector2[] points);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 SetFromCenterAndSize(Vector2 center, Vector2 size);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 Copy(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 MakeEmpty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IsEmpty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Center(Vector2 optionalTarget = default(Vector2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Size(Vector2 optionalTarget = default(Vector2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 ExpandByPoint(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 ExpandByVector(Vector2 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 ExpandByScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsPoint(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsBox(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 GetParameter(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 ClampPoint(Vector2 point, Vector2 optionalTarget = default(Vector2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPoint(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 Intersect(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 Union(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box2 Translate(Vector2 offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionBox(any b);
#pragma warning restore CS0626
    }
    [External]
    public class Box3
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Max { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Min { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Box3(Vector3 min = default(Vector3), Vector3 max = default(Vector3));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Box3 Set(Vector3 min, Vector3 max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 SetFromArray(number[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 SetFromPoints(Vector3[] points);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 SetFromCenterAndSize(Vector3 center, Vector3 size);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 SetFromObject(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 Copy(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 MakeEmpty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IsEmpty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Center(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Size(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 ExpandByPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 ExpandByVector(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 ExpandByScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetParameter(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere GetBoundingSphere(Sphere optionalTarget = default(Sphere));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 Intersect(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 Union(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 ApplyMatrix4(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 Translate(Vector3 offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionBox(any b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionSphere(any s);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONHSL : HSL
    {
#pragma warning disable CS0626
        public extern number H { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number S { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number L { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface HSL
    {
        [FieldProperty]
        number H { get; set; }
        [FieldProperty]
        number S { get; set; }
        [FieldProperty]
        number L { get; set; }
    }
    [External]
    public class Color
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number R { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number G { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Color(Color color = default(Color));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(string color = default(string));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(number color = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(number r, number g, number b);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Color Set(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Set(number color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Set(string color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetHex(number hex);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetRGB(number r, number g, number b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetHSL(number h, number s, number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetStyle(string style);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Copy(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color CopyGammaToLinear(Color color, number gammaFactor = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color CopyLinearToGamma(Color color, number gammaFactor = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color ConvertGammaToLinear();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color ConvertLinearToGamma();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetHex();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetHexString();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HSL GetHSL();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetStyle();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color OffsetHSL(number h, number s, number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Add(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color AddColors(Color color1, Color color2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color AddScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Multiply(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Lerp(Color color, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color FromArray(number[] rgb, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] array = default(number[]), number offset = default(number));
#pragma warning restore CS0626
    }
    [External]
    public class Euler
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Order { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Function OnChangeCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static string[] RotationOrders { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static string DefaultOrder { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Euler(number x = default(number), number y = default(number), number z = default(number), string order = default(string));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Euler Set(number x, number y, number z, string order = default(string));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Copy(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromRotationMatrix(Matrix4 m, string order = default(string), boolean update = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromQuaternion(Quaternion q, string order = default(string), boolean update = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromVector3(Vector3 v, string order = default(string));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Reorder(string newOrder);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler FromArray(any[] xyzo);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] array = default(number[]), number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ToVector3(Vector3 optionalResult = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnChange(Function callback);
#pragma warning restore CS0626
    }
    [External]
    public class Frustum
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Plane[] Planes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Frustum(Plane p0 = default(Plane), Plane p1 = default(Plane), Plane p2 = default(Plane), Plane p3 = default(Plane), Plane p4 = default(Plane), Plane p5 = default(Plane));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Frustum Set(number p0 = default(number), number p1 = default(number), number p2 = default(number), number p3 = default(number), number p4 = default(number), number p5 = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Frustum Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Frustum Copy(Frustum frustum);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Frustum SetFromMatrix(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsObject(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsPoint(Vector3 point);
#pragma warning restore CS0626
    }
    [External]
    public class Line3
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 End { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Line3(Vector3 start = default(Vector3), Vector3 end = default(Vector3));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Line3 Set(Vector3 start = default(Vector3), Vector3 end = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line3 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line3 Copy(Line3 line);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Center(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Delta(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Distance();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 At(number t, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ClosestPointToPointParameter(Vector3 point, boolean clampToLine = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClosestPointToPoint(Vector3 point, boolean clampToLine = default(boolean), Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line3 ApplyMatrix4(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Line3 line);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMatrix : Matrix
    {
#pragma warning disable CS0626
        public extern Float32Array Elements { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix identityDelegate();

#pragma warning disable CS0626
        public extern Matrix Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern identityDelegate identity { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix copyDelegate(Matrix m);

#pragma warning disable CS0626
        public extern Matrix Copy(Matrix m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern copyDelegate copy { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix multiplyScalarDelegate(number s);

#pragma warning disable CS0626
        public extern Matrix MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern multiplyScalarDelegate multiplyScalar { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number determinantDelegate();

#pragma warning disable CS0626
        public extern number Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern determinantDelegate determinant { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix getInverseDelegate(Matrix matrix, boolean throwOnInvertible = default(boolean));

#pragma warning disable CS0626
        public extern Matrix GetInverse(Matrix matrix, boolean throwOnInvertible = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern getInverseDelegate getInverse { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix transposeDelegate();

#pragma warning disable CS0626
        public extern Matrix Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern transposeDelegate transpose { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix cloneDelegate();

#pragma warning disable CS0626
        public extern Matrix Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern cloneDelegate clone { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Matrix
    {
        [FieldProperty]
        Float32Array Elements { get; set; }
        Matrix Identity();
        Matrix Copy(Matrix m);
        Matrix MultiplyScalar(number s);
        number Determinant();
        Matrix GetInverse(Matrix matrix, boolean throwOnInvertible = default(boolean));
        Matrix Transpose();
        Matrix Clone();
    }
    [External]
    public class Matrix3 : Matrix
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Float32Array Elements { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Matrix3();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Matrix3 Set(number n11, number n12, number n13, number n21, number n22, number n23, number n31, number n32, number n33);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 Copy(Matrix3 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 SetFromMatix4(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any MultiplyVector3Array(any a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ApplyToVector3Array(number[] array, number offset = default(number), number length = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute ApplyToBuffer(BufferAttribute buffer, number offset = default(number), number length = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetInverse(Matrix3 matrix, boolean throwOnDegenerate = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetInverse(Matrix4 matrix, boolean throwOnDegenerate = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] FlattenToArrayOffset(number[] array, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetNormalMatrix(Matrix4 matrix4);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] TransposeIntoArray(number[] r);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 FromArray(number[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any MultiplyVector3(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Copy(Matrix m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.GetInverse(Matrix matrix, boolean throwOnInvertible);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Clone();
#pragma warning restore CS0626
    }
    [External]
    public class Matrix4 : Matrix
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Float32Array Elements { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Matrix4();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Matrix4 Set(number n11, number n12, number n13, number n14, number n21, number n22, number n23, number n24, number n31, number n32, number n33, number n34, number n41, number n42, number n43, number n44);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Copy(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 ExtractPosition(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 CopyPosition(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 ExtractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 ExtractRotation(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationFromEuler(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 SetRotationFromQuaternion(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationFromQuaternion(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Multiply(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MultiplyMatrices(Matrix4 a, Matrix4 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MultiplyToArray(Matrix4 a, Matrix4 b, number[] r);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] MultiplyVector3Array(number[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ApplyToVector3Array(number[] array, number offset = default(number), number length = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute ApplyToBuffer(BufferAttribute buffer, number offset = default(number), number length = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] FlattenToArrayOffset(number[] array, number offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 SetPosition(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 GetInverse(Matrix4 m, boolean throwOnDegeneratee = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Scale(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetMaxScaleOnAxis();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeTranslation(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationX(number theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationY(number theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationZ(number theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationAxis(Vector3 axis, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeScale(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Compose(Vector3 translation, Quaternion rotation, Vector3 scale);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object[] Decompose(Vector3 translation = default(Vector3), Quaternion rotation = default(Quaternion), Vector3 scale = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeFrustum(number left, number right, number bottom, number top, number near, number far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakePerspective(number fov, number aspect, number near, number far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeOrthographic(number left, number right, number top, number bottom, number near, number far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 FromArray(number[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetPosition();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any MultiplyVector3(any v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any MultiplyVector4(any v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RotateAxis(any v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void CrossVector(any v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Copy(Matrix m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.GetInverse(Matrix matrix, boolean throwOnInvertible);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Clone();
#pragma warning restore CS0626
    }
    [External]
    public class Plane
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Normal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Constant { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Plane(Vector3 normal = default(Vector3), number constant = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Plane Set(Vector3 normal, number constant);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane SetComponents(number x, number y, number z, number w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane SetFromNormalAndCoplanarPoint(Vector3 normal, Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane SetFromCoplanarPoints(Vector3 a, Vector3 b, Vector3 c);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Copy(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ProjectPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 OrthoPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectLine(Line3 line, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsLine(Line3 line);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 CoplanarPoint(boolean optionalTarget = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane ApplyMatrix4(Matrix4 matrix, Matrix3 optionalNormalMatrix = default(Matrix3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Translate(Vector3 offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionLine(any l);
#pragma warning restore CS0626
    }
    [External]
    public class Spherical
    {
#pragma warning disable CS0824
        public extern Spherical(number radius = default(number), number phi = default(number), number theta = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(number radius, number phi, number theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Spherical Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Spherical Copy(Spherical other);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void MakeSafe();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Spherical SetFromVector3(Vector3 vec3);
#pragma warning restore CS0626
    }
    [External]
    public class Quaternion
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number W { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Function OnChangeCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Quaternion(number x = default(number), number y = default(number), number z = default(number), number w = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Quaternion Set(number x, number y, number z, number w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Copy(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromEuler(Euler euler, boolean update = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromAxisAngle(Vector3 axis, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromRotationMatrix(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromUnitVectors(Vector3 vFrom, Vector3 vTo);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Inverse();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Conjugate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Dot(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Multiply(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion MultiplyQuaternions(Quaternion a, Quaternion b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any MultiplyVector3(any v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Slerp(Quaternion qb, number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Quaternion v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion FromArray(number[] n);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion FromArray(number[] xyzw, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] xyzw = default(number[]), number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion OnChange(Function callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Quaternion Slerp(Quaternion qa, Quaternion qb, Quaternion qm, number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Quaternion SlerpFlat(number[] dst, number dstOffset, number[] src0, number srcOffset, number[] src1, number stcOffset1, number t);
#pragma warning restore CS0626
    }
    [External]
    public class Ray
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Origin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Direction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Ray(Vector3 origin = default(Vector3), Vector3 direction = default(Vector3));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Ray Set(Vector3 origin, Vector3 direction);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray Copy(Ray ray);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 At(number t, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 LookAt(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray Recast(number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClosestPointToPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceSqToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceSqToSegment(Vector3 v0, Vector3 v1, Vector3 optionalPointOnRay = default(Vector3), Vector3 optionalPointOnSegment = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectSphere(Sphere sphere, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectPlane(Plane plane, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectBox(Box3 box, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectTriangle(Vector3 a, Vector3 b, Vector3 c, boolean backfaceCulling, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray ApplyMatrix4(Matrix4 matrix4);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Ray ray);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionSphere(any s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionPlane(any p);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any IsIntersectionBox(any b);
#pragma warning restore CS0626
    }
    [External]
    public class Sphere
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 Center { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Sphere(Vector3 center = default(Vector3), number radius = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Sphere Set(Vector3 center, number radius);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere SetFromPoints(Vector3[] points, Vector3 optionalCenter = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere Copy(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean IntersectsPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Box3 GetBoundingBox(Box3 optionalTarget = default(Box3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere ApplyMatrix4(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sphere Translate(Vector3 offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Sphere sphere);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONSplineControlPoint : SplineControlPoint
    {
#pragma warning disable CS0626
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Z { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface SplineControlPoint
    {
        [FieldProperty]
        number X { get; set; }
        [FieldProperty]
        number Y { get; set; }
        [FieldProperty]
        number Z { get; set; }
    }
    [ObjectLiteral]
    public class JSONGetLengthInterface : GetLengthInterface
    {
#pragma warning disable CS0626
        public extern number[] Chunks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Total { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GetLengthInterface
    {
        [FieldProperty]
        number[] Chunks { get; set; }
        [FieldProperty]
        number Total { get; set; }
    }
    [External]
    public class Spline
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern SplineControlPoint[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Spline(SplineControlPoint[] points);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void InitFromArray(number[][] a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SplineControlPoint GetPoint(number k);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[][] GetControlPointsArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern GetLengthInterface GetLength(number nSubDivisions = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ReparametrizeByArcLength(number samplingCoef);
#pragma warning restore CS0626
    }
    [External]
    public class Triangle
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 A { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 C { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Triangle(Vector3 a = default(Vector3), Vector3 b = default(Vector3), Vector3 c = default(Vector3));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Triangle Set(Vector3 a, Vector3 b, Vector3 c);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Triangle SetFromPointsAndIndices(Vector3[] points, number i0, number i1, number i2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Triangle Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Triangle Copy(Triangle triangle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Area();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Midpoint(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Normal(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Plane(Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 BarycoordFromPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Triangle triangle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector3 Normal(Vector3 a, Vector3 b, Vector3 c, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector3 BarycoordFromPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c, Vector3 optionalTarget);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static boolean ContainsPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONVector : Vector
    {
        [External]
        public delegate void setComponentDelegate(number index, number value);

#pragma warning disable CS0626
        public extern void SetComponent(number index, number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern setComponentDelegate setComponent { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number getComponentDelegate(number index);

#pragma warning disable CS0626
        public extern number GetComponent(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern getComponentDelegate getComponent { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector copyDelegate(Vector v);

#pragma warning disable CS0626
        public extern Vector Copy(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern copyDelegate copy { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector addDelegate(Vector v);

#pragma warning disable CS0626
        public extern Vector Add(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern addDelegate add { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector addVectorsDelegate(Vector a, Vector b);

#pragma warning disable CS0626
        public extern Vector AddVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern addVectorsDelegate addVectors { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector subDelegate(Vector v);

#pragma warning disable CS0626
        public extern Vector Sub(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern subDelegate sub { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector subVectorsDelegate(Vector a, Vector b);

#pragma warning disable CS0626
        public extern Vector SubVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern subVectorsDelegate subVectors { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector multiplyScalarDelegate(number s);

#pragma warning disable CS0626
        public extern Vector MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern multiplyScalarDelegate multiplyScalar { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector divideScalarDelegate(number s);

#pragma warning disable CS0626
        public extern Vector DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern divideScalarDelegate divideScalar { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector negateDelegate();

#pragma warning disable CS0626
        public extern Vector Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern negateDelegate negate { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number dotDelegate(Vector v);

#pragma warning disable CS0626
        public extern number Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern dotDelegate dot { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number lengthSqDelegate();

#pragma warning disable CS0626
        public extern number LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern lengthSqDelegate lengthSq { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number lengthDelegate();

#pragma warning disable CS0626
        public extern number Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern lengthDelegate length { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector normalizeDelegate();

#pragma warning disable CS0626
        public extern Vector Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern normalizeDelegate normalize { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number distanceToDelegate(Vector v);

#pragma warning disable CS0626
        public extern number DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern distanceToDelegate distanceTo { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate number distanceToSquaredDelegate(Vector v);

#pragma warning disable CS0626
        public extern number DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern distanceToSquaredDelegate distanceToSquared { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector setLengthDelegate(number l);

#pragma warning disable CS0626
        public extern Vector SetLength(number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern setLengthDelegate setLength { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector lerpDelegate(Vector v, number alpha);

#pragma warning disable CS0626
        public extern Vector Lerp(Vector v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern lerpDelegate lerp { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate boolean equalsDelegate(Vector v);

#pragma warning disable CS0626
        public extern boolean Equals(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern equalsDelegate equals { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector cloneDelegate();

#pragma warning disable CS0626
        public extern Vector Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern cloneDelegate clone { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Vector
    {
        void SetComponent(number index, number value);
        number GetComponent(number index);
        Vector Copy(Vector v);
        Vector Add(Vector v);
        Vector AddVectors(Vector a, Vector b);
        Vector Sub(Vector v);
        Vector SubVectors(Vector a, Vector b);
        Vector MultiplyScalar(number s);
        Vector DivideScalar(number s);
        Vector Negate();
        number Dot(Vector v);
        number LengthSq();
        number Length();
        Vector Normalize();
        number DistanceTo(Vector v);
        number DistanceToSquared(Vector v);
        Vector SetLength(number l);
        Vector Lerp(Vector v, number alpha);
        boolean Equals(Vector v);
        Vector Clone();
    }
    [External]
    public class Vector2 : Vector
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector2(number x = default(number), number y = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector2 Set(number x, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetX(number x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetY(number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(number index, number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetComponent(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Copy(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Add(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 AddScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 AddVectors(Vector2 a, Vector2 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 AddScaledVector(Vector2 v, number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Sub(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SubVectors(Vector2 a, Vector2 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Multiply(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 MultiplyScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Divide(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Min(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Max(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Clamp(Vector2 min, Vector2 max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 ClampScalar(number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 ClampLength(number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Floor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Ceil();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Round();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 RoundToZero();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Dot(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Angle();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceTo(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToSquared(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetLength(number length);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Lerp(Vector2 v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 LerpVectors(Vector2 v1, Vector2 v2, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 FromArray(number[] xy, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] xy = default(number[]), number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 FromAttribute(BufferAttribute attribute, number index, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 RotateAround(Vector2 center, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Copy(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Add(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.AddVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Sub(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SubVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern boolean Vector.Equals(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Clone();
#pragma warning restore CS0626
    }
    [External]
    public class Vector3 : Vector
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector3(number x = default(number), number y = default(number), number z = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 Set(number x, number y, number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetX(number x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetY(number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetZ(number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(number index, number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetComponent(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Copy(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Add(Vector3 a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 AddScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 AddScaledVector(Vector3 v, number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 AddVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Sub(Vector3 a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SubScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SubVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Multiply(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 MultiplyVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyEuler(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyAxisAngle(Vector3 axis, number angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyMatrix3(Matrix3 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyMatrix4(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyProjection(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyQuaternion(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Project(Camera camera);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Unproject(Camera camera);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 TransformDirection(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Divide(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Min(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Max(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Clamp(Vector3 min, Vector3 max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampScalar(number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampLength(number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Floor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Ceil();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Round();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 RoundToZero();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Dot(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetLength(number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Lerp(Vector3 v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 LerpVectors(Vector3 v1, Vector3 v2, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Cross(Vector3 a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 CrossVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ProjectOnVector(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ProjectOnPlane(Vector3 planeNormal);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Reflect(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number AngleTo(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceTo(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToSquared(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 SetFromSpherical(Spherical s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetPositionFromMatrix(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixPosition(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetScaleFromMatrix(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixScale(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetColumnFromMatrixColumn(number index, Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixColumn(Matrix4 matrix, number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixColumn(number index, Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 FromArray(number[] xyz, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] xyz = default(number[]), number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 FromAttribute(BufferAttribute attribute, number index, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Copy(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Add(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.AddVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Sub(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SubVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern boolean Vector.Equals(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Clone();
#pragma warning restore CS0626
    }
    [External]
    public class Vertex : Vector3
    {
#pragma warning disable CS0824
        extern Vertex();
#pragma warning restore CS0824
    }
    [External]
    public class Vector4 : Vector
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number W { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector4(number x = default(number), number y = default(number), number z = default(number), number w = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector4 Set(number x, number y, number z, number w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetScalar(number scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetX(number x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetY(number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetZ(number z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetW(number w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(number index, number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetComponent(number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Copy(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Add(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 AddScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 AddVectors(Vector4 a, Vector4 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 AddScaledVector(Vector4 v, number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Sub(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SubScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SubVectors(Vector4 a, Vector4 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 ApplyMatrix4(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetAxisAngleFromQuaternion(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetAxisAngleFromRotationMatrix(Matrix3 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Min(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Max(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Clamp(Vector4 min, Vector4 max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 ClampScalar(number min, number max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Floor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Ceil();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Round();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 RoundToZero();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Dot(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetLength(number length);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Lerp(Vector4 v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 LerpVectors(Vector4 v1, Vector4 v2, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Equals(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 FromArray(number[] xyzw, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] ToArray(number[] xyzw = default(number[]), number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 FromAttribute(BufferAttribute attribute, number index, number offset = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Copy(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Add(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.AddVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Sub(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SubVectors(Vector a, Vector b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.MultiplyScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(number s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern number Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(number l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern boolean Vector.Equals(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Clone();
#pragma warning restore CS0626
    }
    [External]
    public abstract class Interpolant
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ParameterPositions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any SamplesValues { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ValueSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any ResultBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Interpolant(any parameterPositions, any samplesValues, number sampleSize, any resultBuffer = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Evaluate(number time);
#pragma warning restore CS0626
    }
    [External]
    public class CubicInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern CubicInterpolant(any parameterPositions, any samplesValues, number sampleSize, any resultBuffer = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Interpolate_(number i1, number t0, number t, number t1);
#pragma warning restore CS0626
    }
    [External]
    public class DiscreteInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern DiscreteInterpolant(any parameterPositions, any samplesValues, number sampleSize, any resultBuffer = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Interpolate_(number i1, number t0, number t, number t1);
#pragma warning restore CS0626
    }
    [External]
    public class LinearInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern LinearInterpolant(any parameterPositions, any samplesValues, number sampleSize, any resultBuffer = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Interpolate_(number i1, number t0, number t, number t1);
#pragma warning restore CS0626
    }
    [External]
    public class QuaternionLinearInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern QuaternionLinearInterpolant(any parameterPositions, any samplesValues, number sampleSize, any resultBuffer = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Interpolate_(number i1, number t0, number t, number t1);
#pragma warning restore CS0626
    }
    [External]
    public class Bone : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern SkinnedMesh Skin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Bone(SkinnedMesh skin);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Bone Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Bone Copy(Bone source);
#pragma warning restore CS0626
    }
    [External]
    public class Group : Object3D
    {
#pragma warning disable CS0824
        public extern Group();
#pragma warning restore CS0824
    }
    [External]
    public class LOD : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Levels { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Objects { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LOD();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddLevel(Object3D @object, number distance = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetObjectForDistance(number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update(Camera camera);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LOD Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LOD Copy(LOD source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONLensFlareProperty : LensFlareProperty
    {
#pragma warning disable CS0626
        public extern Texture Texture { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LensFlareProperty
    {
        [FieldProperty]
        Texture Texture { get; set; }
        [FieldProperty]
        number Size { get; set; }
        [FieldProperty]
        number Distance { get; set; }
        [FieldProperty]
        number X { get; set; }
        [FieldProperty]
        number Y { get; set; }
        [FieldProperty]
        number Z { get; set; }
        [FieldProperty]
        number Scale { get; set; }
        [FieldProperty]
        number Rotation { get; set; }
        [FieldProperty]
        number Opacity { get; set; }
        [FieldProperty]
        Color Color { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
    }
    [External]
    public delegate void customUpdateCallbackDelegate(LensFlare @object);
    [External]
    public class LensFlare : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern LensFlareProperty[] LensFlares { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 PositionScreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern customUpdateCallbackDelegate CustomUpdateCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LensFlare(Texture texture = default(Texture), number size = default(number), number distance = default(number), Blending blending = default(Blending), Color color = default(Color));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Add(Texture texture, number size = default(number), number distance = default(number), Blending blending = default(Blending), Color color = default(Color));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateLensFlares();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LensFlare Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LensFlare Copy(LensFlare source);
#pragma warning restore CS0626
    }
    [External]
    public class Line : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Any<Geometry, BufferGeometry> Geometry { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material Material { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Line(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial> material = default(Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial>), number mode = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line Copy(Line source);
#pragma warning restore CS0626
    }
    [External]
    public class LineSegments : Line
    {
#pragma warning disable CS0824
        public extern LineSegments(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial> material = default(Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial>), number mode = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern LineSegments Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LineSegments Copy(LineSegments source);
#pragma warning restore CS0626
    }
    [External]
    public enum LineMode
    {

    }
    [External]
    public class Mesh : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Any<Geometry, BufferGeometry> Geometry { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material Material { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TrianglesDrawModes DrawMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Mesh(Geometry geometry = default(Geometry), Material material = default(Material));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Mesh(BufferGeometry geometry = default(BufferGeometry), Material material = default(Material));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetDrawMode(TrianglesDrawModes drawMode);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMorphTargets();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetMorphTargetIndexByName(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Mesh Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Mesh Copy(Mesh source);
#pragma warning restore CS0626
    }
    [External]
    public class Points : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Any<Geometry, BufferGeometry> Geometry { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material Material { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Points(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), Material material = default(Material));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Points Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Points Copy(Points source);
#pragma warning restore CS0626
    }
    [External]
    public class PointCloud : Points
    {
#pragma warning disable CS0824
        extern PointCloud();
#pragma warning restore CS0824
    }
    [External]
    public class ParticleSystem : Points
    {
#pragma warning disable CS0824
        extern ParticleSystem();
#pragma warning restore CS0824
    }
    [External]
    public class Skeleton
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean UseVertexTexture { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 IdentityMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Bone[] Bones { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BoneTextureWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number BoneTextureHeight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Float32Array BoneMatrices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern DataTexture BoneTexture { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4[] BoneInverses { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Skeleton(Bone[] bones, Matrix4[] boneInverses = default(Matrix4[]), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void CalculateInverses(Bone bone);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Pose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Skeleton Clone();
#pragma warning restore CS0626
    }
    [External]
    public class SkinnedMesh : Mesh
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string BindMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 BindMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Matrix4 BindMatrixInverse { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Skeleton Skeleton { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshBasicMaterial material = default(MeshBasicMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshDepthMaterial material = default(MeshDepthMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MultiMaterial material = default(MultiMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshLambertMaterial material = default(MeshLambertMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshNormalMaterial material = default(MeshNormalMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshPhongMaterial material = default(MeshPhongMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), ShaderMaterial material = default(ShaderMaterial), boolean useVertexTexture = default(boolean));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Bind(Skeleton skeleton, Matrix4 bindMatrix = default(Matrix4));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Pose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void NormalizeSkinWeights();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMatrixWorld(boolean force = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SkinnedMesh Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SkinnedMesh Copy(SkinnedMesh source);
#pragma warning restore CS0626
    }
    [External]
    public class Sprite : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern BufferGeometry Geometry { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern SpriteMaterial Material { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Sprite(Material material = default(Material));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, any intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sprite Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Sprite Copy(Sprite source);
#pragma warning restore CS0626
    }
    [External]
    public class Particle : Sprite
    {
#pragma warning disable CS0824
        extern Particle();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONRenderer : Renderer
    {
#pragma warning disable CS0626
        public extern HTMLCanvasElement DomElement { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate void renderDelegate(Scene scene, Camera camera);

#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern renderDelegate render { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate void setSizeDelegate(number width, number height, boolean updateStyle = default(boolean));

#pragma warning disable CS0626
        public extern void SetSize(number width, number height, boolean updateStyle = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern setSizeDelegate setSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Renderer
    {
        [FieldProperty]
        HTMLCanvasElement DomElement { get; set; }
        void Render(Scene scene, Camera camera);
        void SetSize(number width, number height, boolean updateStyle = default(boolean));
    }
    [ObjectLiteral]
    public class JSONWebGLRendererParameters : WebGLRendererParameters
    {
#pragma warning disable CS0626
        public extern HTMLCanvasElement Canvas { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Alpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Antialias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Stencil { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean PreserveDrawingBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ClearColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ClearAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DevicePixelRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean LogarithmicDepthBuffer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WebGLRendererParameters
    {
        [FieldProperty]
        HTMLCanvasElement Canvas { get; set; }
        [FieldProperty]
        string Precision { get; set; }
        [FieldProperty]
        boolean Alpha { get; set; }
        [FieldProperty]
        boolean PremultipliedAlpha { get; set; }
        [FieldProperty]
        boolean Antialias { get; set; }
        [FieldProperty]
        boolean Stencil { get; set; }
        [FieldProperty]
        boolean PreserveDrawingBuffer { get; set; }
        [FieldProperty]
        number ClearColor { get; set; }
        [FieldProperty]
        number ClearAlpha { get; set; }
        [FieldProperty]
        number DevicePixelRatio { get; set; }
        [FieldProperty]
        boolean LogarithmicDepthBuffer { get; set; }
    }
    [ObjectLiteral]
    public class JSONMemoryInterface : MemoryInterface
    {
#pragma warning disable CS0626
        public extern number Geometries { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Textures { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MemoryInterface
    {
        [FieldProperty]
        number Geometries { get; set; }
        [FieldProperty]
        number Textures { get; set; }
    }
    [ObjectLiteral]
    public class JSONRenderInterface : RenderInterface
    {
#pragma warning disable CS0626
        public extern number Calls { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Vertices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Faces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Points { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface RenderInterface
    {
        [FieldProperty]
        number Calls { get; set; }
        [FieldProperty]
        number Vertices { get; set; }
        [FieldProperty]
        number Faces { get; set; }
        [FieldProperty]
        number Points { get; set; }
    }
    [ObjectLiteral]
    public class JSONInfoInterface : InfoInterface
    {
#pragma warning disable CS0626
        public extern MemoryInterface Memory { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern RenderInterface Render { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Programs { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface InfoInterface
    {
        [FieldProperty]
        MemoryInterface Memory { get; set; }
        [FieldProperty]
        RenderInterface Render { get; set; }
        [FieldProperty]
        number Programs { get; set; }
    }
    [ObjectLiteral]
    public class JSONGetSizeInterface : GetSizeInterface
    {
#pragma warning disable CS0626
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GetSizeInterface
    {
        [FieldProperty]
        number Width { get; set; }
        [FieldProperty]
        number Height { get; set; }
    }
    [External]
    public class WebGLRenderer : Renderer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern HTMLCanvasElement DomElement { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLRenderingContext Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoClear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoClearColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoClearDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoClearStencil { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean SortObjects { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLExtensions Extensions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number GammaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean GammaInput { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean GammaOutput { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean PhysicallyCorrectLights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ToneMapping ToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ToneMappingExposure { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ToneMappingWhitePoint { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ShadowMapDebug { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MaxMorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number MaxMorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoScaleCubemaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern InfoInterface Info { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLShadowMap ShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ShadowMapType ShadowMapType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ShadowMapEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern CullFace ShadowMapCullFace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number PixelRation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLCapabilities Capabilities { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLProperties Properties { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLState State { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLRenderer(WebGLRendererParameters parameters = default(WebGLRendererParameters));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern WebGLRenderingContext GetContext();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetContextAttributes();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ForceContextLoss();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetMaxAnisotropy();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetPrecision();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetPixelRatio();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPixelRatio(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern GetSizeInterface GetSize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetSize(number width, number height, boolean updateStyle = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetViewport(number x = default(number), number y = default(number), number width = default(number), number height = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissor(number x, number y, number width, number height);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissorTest(boolean enable);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color GetClearColor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(Color color, number alpha = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(string color, number alpha = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(number color, number alpha = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetClearAlpha();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearAlpha(number alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Clear(boolean color = default(boolean), boolean depth = default(boolean), boolean stencil = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearColor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearDepth();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearStencil();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearTarget(WebGLRenderTarget renderTarget, boolean color, boolean depth, boolean stencil);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ResetGLState();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderBufferImmediate(Object3D @object, Object program, Material material);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderBufferDirect(Camera camera, Fog fog, Material material, any geometryGroup, Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, RenderTarget renderTarget = default(RenderTarget), boolean forceClear = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFaceCulling(CullFace cullFace = default(CullFace), FrontFaceDirection frontFace = default(FrontFaceDirection));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexture(Texture texture, number slot);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern RenderTarget GetCurrentRenderTarget();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRenderTarget(RenderTarget renderTarget);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ReadRenderTargetPixels(RenderTarget renderTarget, number x, number y, number width, number height, any buffer);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsFloatTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsHalfFloatTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsStandardDerivatives();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsCompressedTextureS3TC();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsCompressedTexturePVRTC();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsBlendMinMax();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsVertexTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any SupportsInstancedArrays();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any EnableScissorTest(any boolean);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern void Renderer.Render(Scene scene, Camera camera);
#pragma warning restore CS0626
    }
    [External]
    public interface RenderTarget
    {
    }
    [ObjectLiteral]
    public class JSONWebGLRenderTargetOptions : WebGLRenderTargetOptions
    {
#pragma warning disable CS0626
        public extern Wrapping WrapS { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Wrapping WrapT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern TextureFilter MagFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern TextureFilter MinFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern TextureDataType Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Anisotropy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean StencilBuffer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WebGLRenderTargetOptions
    {
        [FieldProperty]
        Wrapping WrapS { get; set; }
        [FieldProperty]
        Wrapping WrapT { get; set; }
        [FieldProperty]
        TextureFilter MagFilter { get; set; }
        [FieldProperty]
        TextureFilter MinFilter { get; set; }
        [FieldProperty]
        number Format { get; set; }
        [FieldProperty]
        TextureDataType Type { get; set; }
        [FieldProperty]
        number Anisotropy { get; set; }
        [FieldProperty]
        boolean DepthBuffer { get; set; }
        [FieldProperty]
        boolean StencilBuffer { get; set; }
    }
    [External]
    public delegate void addEventListenerParam2Delegate5(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate5(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate5(Event @event);
    [External]
    public class WebGLRenderTarget : RenderTarget
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector4 Scissor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean ScissorTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector4 Viewpport { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture Texture { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean DepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean StencilBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any WrapS { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any WrapT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MagFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MinFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Anisotropy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Repeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any GenerateMipmaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLRenderTarget(number width, number height, WebGLRenderTargetOptions options = default(WebGLRenderTargetOptions));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetSize(number width, number height);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern WebGLRenderTarget Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern WebGLRenderTarget Copy(WebGLRenderTarget source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate5 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate5 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate5 listener);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLRenderTargetCube : WebGLRenderTarget
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ActiveCubeFace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ActiveMipMapLevel { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLRenderTargetCube(number width, number height, WebGLRenderTargetOptions options = default(WebGLRenderTargetOptions));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONShaderChunkInterface : ShaderChunkInterface
    {
#pragma warning disable CS0626
        public extern string Alphamap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Alphamap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Alphatest_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Aomap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Aomap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Begin_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Beginnormal_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Bsdfs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Bumpmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Color_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Color_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Color_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Color_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Common { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Cube_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Cube_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Cube_uv_reflection_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Defaultnormal_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Depth_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Depth_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string DepthRGBA_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string DepthRGBA_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string DistanceRGBA_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string DistanceRGBA_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Displacementmap_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Displacementmap_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Emissivemap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Emissivemap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Encodings_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Encodings_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Envmap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Envmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Envmap_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Envmap_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Equirect_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Equirect_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Fog_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Fog_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Linedashed_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Linedashed_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lightmap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lightmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_lambert_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_pars { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_phong_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_phong_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_phong_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_phong_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_standard_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_standard_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Lights_template { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Logdepthbuf_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Logdepthbuf_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Logdepthbuf_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Logdepthbuf_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Map_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Map_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Map_particle_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Map_particle_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshbasic_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshbasic_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshlambert_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshlambert_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshphong_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshphong_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshstandard_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Meshstandard_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Metalnessmap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Metalnessmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Morphnormal_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Morphtarget_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Morphtarget_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Normal_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Normal_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Normal_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Normalmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Points_frag { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Points_vert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Premultiplied_alpha_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Project_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Roughnessmap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Roughnessmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Shadowmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Shadowmap_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Shadowmap_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Shadowmask_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Skinbase_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Skinning_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Skinning_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Skinnormal_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Specularmap_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Specularmap_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Tonemapping_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Tonemapping_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv2_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv2_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv2_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv_pars_fragment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv_pars_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Uv_vertex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Worldpos_vertex { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate string ShaderChunkInterfaceIndexerDelegate(string name);

#pragma warning disable CS0626
        public extern string this[string name] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShaderChunkInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShaderChunkInterface
    {
        [FieldProperty]
        string Alphamap_fragment { get; set; }
        [FieldProperty]
        string Alphamap_pars_fragment { get; set; }
        [FieldProperty]
        string Alphatest_fragment { get; set; }
        [FieldProperty]
        string Aomap_fragment { get; set; }
        [FieldProperty]
        string Aomap_pars_fragment { get; set; }
        [FieldProperty]
        string Begin_vertex { get; set; }
        [FieldProperty]
        string Beginnormal_vertex { get; set; }
        [FieldProperty]
        string Bsdfs { get; set; }
        [FieldProperty]
        string Bumpmap_pars_fragment { get; set; }
        [FieldProperty]
        string Color_fragment { get; set; }
        [FieldProperty]
        string Color_pars_fragment { get; set; }
        [FieldProperty]
        string Color_pars_vertex { get; set; }
        [FieldProperty]
        string Color_vertex { get; set; }
        [FieldProperty]
        string Common { get; set; }
        [FieldProperty]
        string Cube_frag { get; set; }
        [FieldProperty]
        string Cube_vert { get; set; }
        [FieldProperty]
        string Cube_uv_reflection_fragment { get; set; }
        [FieldProperty]
        string Defaultnormal_vertex { get; set; }
        [FieldProperty]
        string Depth_frag { get; set; }
        [FieldProperty]
        string Depth_vert { get; set; }
        [FieldProperty]
        string DepthRGBA_frag { get; set; }
        [FieldProperty]
        string DepthRGBA_vert { get; set; }
        [FieldProperty]
        string DistanceRGBA_frag { get; set; }
        [FieldProperty]
        string DistanceRGBA_vert { get; set; }
        [FieldProperty]
        string Displacementmap_vertex { get; set; }
        [FieldProperty]
        string Displacementmap_pars_vertex { get; set; }
        [FieldProperty]
        string Emissivemap_fragment { get; set; }
        [FieldProperty]
        string Emissivemap_pars_fragment { get; set; }
        [FieldProperty]
        string Encodings_pars_fragment { get; set; }
        [FieldProperty]
        string Encodings_fragment { get; set; }
        [FieldProperty]
        string Envmap_fragment { get; set; }
        [FieldProperty]
        string Envmap_pars_fragment { get; set; }
        [FieldProperty]
        string Envmap_pars_vertex { get; set; }
        [FieldProperty]
        string Envmap_vertex { get; set; }
        [FieldProperty]
        string Equirect_frag { get; set; }
        [FieldProperty]
        string Equirect_vert { get; set; }
        [FieldProperty]
        string Fog_fragment { get; set; }
        [FieldProperty]
        string Fog_pars_fragment { get; set; }
        [FieldProperty]
        string Linedashed_frag { get; set; }
        [FieldProperty]
        string Linedashed_vert { get; set; }
        [FieldProperty]
        string Lightmap_fragment { get; set; }
        [FieldProperty]
        string Lightmap_pars_fragment { get; set; }
        [FieldProperty]
        string Lights_lambert_vertex { get; set; }
        [FieldProperty]
        string Lights_pars { get; set; }
        [FieldProperty]
        string Lights_phong_fragment { get; set; }
        [FieldProperty]
        string Lights_phong_pars_fragment { get; set; }
        [FieldProperty]
        string Lights_phong_pars_vertex { get; set; }
        [FieldProperty]
        string Lights_phong_vertex { get; set; }
        [FieldProperty]
        string Lights_standard_fragment { get; set; }
        [FieldProperty]
        string Lights_standard_pars_fragment { get; set; }
        [FieldProperty]
        string Lights_template { get; set; }
        [FieldProperty]
        string Logdepthbuf_fragment { get; set; }
        [FieldProperty]
        string Logdepthbuf_pars_fragment { get; set; }
        [FieldProperty]
        string Logdepthbuf_pars_vertex { get; set; }
        [FieldProperty]
        string Logdepthbuf_vertex { get; set; }
        [FieldProperty]
        string Map_fragment { get; set; }
        [FieldProperty]
        string Map_pars_fragment { get; set; }
        [FieldProperty]
        string Map_particle_fragment { get; set; }
        [FieldProperty]
        string Map_particle_pars_fragment { get; set; }
        [FieldProperty]
        string Meshbasic_frag { get; set; }
        [FieldProperty]
        string Meshbasic_vert { get; set; }
        [FieldProperty]
        string Meshlambert_frag { get; set; }
        [FieldProperty]
        string Meshlambert_vert { get; set; }
        [FieldProperty]
        string Meshphong_frag { get; set; }
        [FieldProperty]
        string Meshphong_vert { get; set; }
        [FieldProperty]
        string Meshstandard_frag { get; set; }
        [FieldProperty]
        string Meshstandard_vert { get; set; }
        [FieldProperty]
        string Metalnessmap_fragment { get; set; }
        [FieldProperty]
        string Metalnessmap_pars_fragment { get; set; }
        [FieldProperty]
        string Morphnormal_vertex { get; set; }
        [FieldProperty]
        string Morphtarget_pars_vertex { get; set; }
        [FieldProperty]
        string Morphtarget_vertex { get; set; }
        [FieldProperty]
        string Normal_frag { get; set; }
        [FieldProperty]
        string Normal_fragment { get; set; }
        [FieldProperty]
        string Normal_vert { get; set; }
        [FieldProperty]
        string Normalmap_pars_fragment { get; set; }
        [FieldProperty]
        string Points_frag { get; set; }
        [FieldProperty]
        string Points_vert { get; set; }
        [FieldProperty]
        string Premultiplied_alpha_fragment { get; set; }
        [FieldProperty]
        string Project_vertex { get; set; }
        [FieldProperty]
        string Roughnessmap_fragment { get; set; }
        [FieldProperty]
        string Roughnessmap_pars_fragment { get; set; }
        [FieldProperty]
        string Shadowmap_pars_fragment { get; set; }
        [FieldProperty]
        string Shadowmap_pars_vertex { get; set; }
        [FieldProperty]
        string Shadowmap_vertex { get; set; }
        [FieldProperty]
        string Shadowmask_pars_fragment { get; set; }
        [FieldProperty]
        string Skinbase_vertex { get; set; }
        [FieldProperty]
        string Skinning_pars_vertex { get; set; }
        [FieldProperty]
        string Skinning_vertex { get; set; }
        [FieldProperty]
        string Skinnormal_vertex { get; set; }
        [FieldProperty]
        string Specularmap_fragment { get; set; }
        [FieldProperty]
        string Specularmap_pars_fragment { get; set; }
        [FieldProperty]
        string Tonemapping_fragment { get; set; }
        [FieldProperty]
        string Tonemapping_pars_fragment { get; set; }
        [FieldProperty]
        string Uv2_pars_fragment { get; set; }
        [FieldProperty]
        string Uv2_pars_vertex { get; set; }
        [FieldProperty]
        string Uv2_vertex { get; set; }
        [FieldProperty]
        string Uv_pars_fragment { get; set; }
        [FieldProperty]
        string Uv_pars_vertex { get; set; }
        [FieldProperty]
        string Uv_vertex { get; set; }
        [FieldProperty]
        string Worldpos_vertex { get; set; }
        string this[string name] { get; set; }
    }
    [ObjectLiteral]
    public class JSONShader : Shader
    {
#pragma warning disable CS0626
        public extern any Uniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string VertexShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string FragmentShader { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Shader
    {
        [FieldProperty]
        any Uniforms { get; set; }
        [FieldProperty]
        string VertexShader { get; set; }
        [FieldProperty]
        string FragmentShader { get; set; }
    }
    [ObjectLiteral]
    public class JSONShaderLibInterface : ShaderLibInterface
    {
#pragma warning disable CS0626
        public extern Shader Basic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Lambert { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Phong { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Standard { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Dashed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Depth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Normal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Cube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader Equirect { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader DepthRGBA { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shader DistanceRGBA { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Shader ShaderLibInterfaceIndexerDelegate(string name);

#pragma warning disable CS0626
        public extern Shader this[string name] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShaderLibInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShaderLibInterface
    {
        [FieldProperty]
        Shader Basic { get; set; }
        [FieldProperty]
        Shader Lambert { get; set; }
        [FieldProperty]
        Shader Phong { get; set; }
        [FieldProperty]
        Shader Standard { get; set; }
        [FieldProperty]
        Shader Points { get; set; }
        [FieldProperty]
        Shader Dashed { get; set; }
        [FieldProperty]
        Shader Depth { get; set; }
        [FieldProperty]
        Shader Normal { get; set; }
        [FieldProperty]
        Shader Cube { get; set; }
        [FieldProperty]
        Shader Equirect { get; set; }
        [FieldProperty]
        Shader DepthRGBA { get; set; }
        [FieldProperty]
        Shader DistanceRGBA { get; set; }
        Shader this[string name] { get; set; }
    }
    [ObjectLiteral]
    public class JSONIUniform : IUniform
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Value { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface IUniform
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any Value { get; set; }
    }
    [ObjectLiteral]
    public class JSONCommonInterface : CommonInterface
    {
#pragma warning disable CS0626
        public extern IUniform Diffuse { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform OffsetRepeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform SpecularMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform AlphaMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform EnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform FlipEnvMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform RefractionRation { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface CommonInterface
    {
        [FieldProperty]
        IUniform Diffuse { get; set; }
        [FieldProperty]
        IUniform Opacity { get; set; }
        [FieldProperty]
        IUniform Map { get; set; }
        [FieldProperty]
        IUniform OffsetRepeat { get; set; }
        [FieldProperty]
        IUniform SpecularMap { get; set; }
        [FieldProperty]
        IUniform AlphaMap { get; set; }
        [FieldProperty]
        IUniform EnvMap { get; set; }
        [FieldProperty]
        IUniform FlipEnvMap { get; set; }
        [FieldProperty]
        IUniform Reflectivity { get; set; }
        [FieldProperty]
        IUniform RefractionRation { get; set; }
    }
    [ObjectLiteral]
    public class JSONAomapInterface : AomapInterface
    {
#pragma warning disable CS0626
        public extern IUniform AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform AoMapIntensity { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface AomapInterface
    {
        [FieldProperty]
        IUniform AoMap { get; set; }
        [FieldProperty]
        IUniform AoMapIntensity { get; set; }
    }
    [ObjectLiteral]
    public class JSONLightmapInterface : LightmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform LightMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform LightMapIntensity { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LightmapInterface
    {
        [FieldProperty]
        IUniform LightMap { get; set; }
        [FieldProperty]
        IUniform LightMapIntensity { get; set; }
    }
    [ObjectLiteral]
    public class JSONEmissivemapInterface : EmissivemapInterface
    {
#pragma warning disable CS0626
        public extern IUniform EmissiveMap { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface EmissivemapInterface
    {
        [FieldProperty]
        IUniform EmissiveMap { get; set; }
    }
    [ObjectLiteral]
    public class JSONBumpmapInterface : BumpmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform BumpScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface BumpmapInterface
    {
        [FieldProperty]
        IUniform BumpMap { get; set; }
        [FieldProperty]
        IUniform BumpScale { get; set; }
    }
    [ObjectLiteral]
    public class JSONNormalmapInterface : NormalmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform NormalScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface NormalmapInterface
    {
        [FieldProperty]
        IUniform NormalMap { get; set; }
        [FieldProperty]
        IUniform NormalScale { get; set; }
    }
    [ObjectLiteral]
    public class JSONDisplacementmapInterface : DisplacementmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform DisplacementBias { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DisplacementmapInterface
    {
        [FieldProperty]
        IUniform DisplacementMap { get; set; }
        [FieldProperty]
        IUniform DisplacementScale { get; set; }
        [FieldProperty]
        IUniform DisplacementBias { get; set; }
    }
    [ObjectLiteral]
    public class JSONRoughnessmapInterface : RoughnessmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform RoughnessMap { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface RoughnessmapInterface
    {
        [FieldProperty]
        IUniform RoughnessMap { get; set; }
    }
    [ObjectLiteral]
    public class JSONMetalnessmapInterface : MetalnessmapInterface
    {
#pragma warning disable CS0626
        public extern IUniform MetalnessMap { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MetalnessmapInterface
    {
        [FieldProperty]
        IUniform MetalnessMap { get; set; }
    }
    [ObjectLiteral]
    public class JSONFogInterface : FogInterface
    {
#pragma warning disable CS0626
        public extern IUniform FogDensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform FogNear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform FogFar { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform FogColor { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface FogInterface
    {
        [FieldProperty]
        IUniform FogDensity { get; set; }
        [FieldProperty]
        IUniform FogNear { get; set; }
        [FieldProperty]
        IUniform FogFar { get; set; }
        [FieldProperty]
        IUniform FogColor { get; set; }
    }
    [ObjectLiteral]
    public class JSONDirectionInterface : DirectionInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DirectionInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONColorInterface : ColorInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ColorInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowInterface : ShadowInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowBiasInterface : ShadowBiasInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowBiasInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowRadiusInterface : ShadowRadiusInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowRadiusInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowMapSizeInterface : ShadowMapSizeInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowMapSizeInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONPropertiesInterface : PropertiesInterface
    {
#pragma warning disable CS0626
        public extern DirectionInterface Direction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ColorInterface Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowInterface Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowBiasInterface ShadowBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowRadiusInterface ShadowRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowMapSizeInterface ShadowMapSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PropertiesInterface
    {
        [FieldProperty]
        DirectionInterface Direction { get; set; }
        [FieldProperty]
        ColorInterface Color { get; set; }
        [FieldProperty]
        ShadowInterface Shadow { get; set; }
        [FieldProperty]
        ShadowBiasInterface ShadowBias { get; set; }
        [FieldProperty]
        ShadowRadiusInterface ShadowRadius { get; set; }
        [FieldProperty]
        ShadowMapSizeInterface ShadowMapSize { get; set; }
    }
    [ObjectLiteral]
    public class JSONIrectionalLightsInterface : IrectionalLightsInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PropertiesInterface Properties { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface IrectionalLightsInterface
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any[] Value { get; set; }
        [FieldProperty]
        PropertiesInterface Properties { get; set; }
    }
    [ObjectLiteral]
    public class JSONPositionInterface : PositionInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PositionInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONDistanceInterface : DistanceInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DistanceInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONConeCosInterface : ConeCosInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ConeCosInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONPenumbraCosInterface : PenumbraCosInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PenumbraCosInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONDecayInterface : DecayInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DecayInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONSpotLightsInterface : SpotLightsInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PropertiesInterface Properties { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface SpotLightsInterface
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any[] Value { get; set; }
        [FieldProperty]
        PropertiesInterface Properties { get; set; }
    }
    [ObjectLiteral]
    public class JSONColorInterface1 : ColorInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ColorInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowInterface1 : ShadowInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowBiasInterface1 : ShadowBiasInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowBiasInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowRadiusInterface1 : ShadowRadiusInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowRadiusInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONShadowMapSizeInterface1 : ShadowMapSizeInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShadowMapSizeInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONPropertiesInterface1 : PropertiesInterface1
    {
#pragma warning disable CS0626
        public extern ColorInterface1 Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PositionInterface Position { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DecayInterface Decay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DistanceInterface Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowInterface1 Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowBiasInterface1 ShadowBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowRadiusInterface1 ShadowRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShadowMapSizeInterface1 ShadowMapSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PropertiesInterface1
    {
        [FieldProperty]
        ColorInterface1 Color { get; set; }
        [FieldProperty]
        PositionInterface Position { get; set; }
        [FieldProperty]
        DecayInterface Decay { get; set; }
        [FieldProperty]
        DistanceInterface Distance { get; set; }
        [FieldProperty]
        ShadowInterface1 Shadow { get; set; }
        [FieldProperty]
        ShadowBiasInterface1 ShadowBias { get; set; }
        [FieldProperty]
        ShadowRadiusInterface1 ShadowRadius { get; set; }
        [FieldProperty]
        ShadowMapSizeInterface1 ShadowMapSize { get; set; }
    }
    [ObjectLiteral]
    public class JSONPointLightsInterface : PointLightsInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PropertiesInterface1 Properties { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointLightsInterface
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any[] Value { get; set; }
        [FieldProperty]
        PropertiesInterface1 Properties { get; set; }
    }
    [ObjectLiteral]
    public class JSONDirectionInterface1 : DirectionInterface1
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DirectionInterface1
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONSkycolorInterface : SkycolorInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface SkycolorInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONGroundColorInterface : GroundColorInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GroundColorInterface
    {
        [FieldProperty]
        string Type { get; set; }
    }
    [ObjectLiteral]
    public class JSONPropertiesInterface2 : PropertiesInterface2
    {
#pragma warning disable CS0626
        public extern DirectionInterface1 Direction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SkycolorInterface Skycolor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern GroundColorInterface GroundColor { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PropertiesInterface2
    {
        [FieldProperty]
        DirectionInterface1 Direction { get; set; }
        [FieldProperty]
        SkycolorInterface Skycolor { get; set; }
        [FieldProperty]
        GroundColorInterface GroundColor { get; set; }
    }
    [ObjectLiteral]
    public class JSONHemisphereLigttsInterface : HemisphereLigttsInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PropertiesInterface2 Properties { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface HemisphereLigttsInterface
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        any[] Value { get; set; }
        [FieldProperty]
        PropertiesInterface2 Properties { get; set; }
    }
    [ObjectLiteral]
    public class JSONLightsInterface : LightsInterface
    {
#pragma warning disable CS0626
        public extern IUniform AmbientLightColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IrectionalLightsInterface IrectionalLights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform DirectionalShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform DirectionalShadowMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SpotLightsInterface SpotLights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform SpotShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform SpotShadowMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointLightsInterface PointLights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform PointShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern IUniform PointShadowMatrix { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HemisphereLigttsInterface HemisphereLigtts { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LightsInterface
    {
        [FieldProperty]
        IUniform AmbientLightColor { get; set; }
        [FieldProperty]
        IrectionalLightsInterface IrectionalLights { get; set; }
        [FieldProperty]
        IUniform DirectionalShadowMap { get; set; }
        [FieldProperty]
        IUniform DirectionalShadowMatrix { get; set; }
        [FieldProperty]
        SpotLightsInterface SpotLights { get; set; }
        [FieldProperty]
        IUniform SpotShadowMap { get; set; }
        [FieldProperty]
        IUniform SpotShadowMatrix { get; set; }
        [FieldProperty]
        PointLightsInterface PointLights { get; set; }
        [FieldProperty]
        IUniform PointShadowMap { get; set; }
        [FieldProperty]
        IUniform PointShadowMatrix { get; set; }
        [FieldProperty]
        HemisphereLigttsInterface HemisphereLigtts { get; set; }
    }
    [ObjectLiteral]
    public class JSONUniformsLibInterface : UniformsLibInterface
    {
#pragma warning disable CS0626
        public extern CommonInterface Common { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AomapInterface Aomap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LightmapInterface Lightmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern EmissivemapInterface Emissivemap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BumpmapInterface Bumpmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern NormalmapInterface Normalmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DisplacementmapInterface Displacementmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern RoughnessmapInterface Roughnessmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern MetalnessmapInterface Metalnessmap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern FogInterface Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LightsInterface Lights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointsInterface Points { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface UniformsLibInterface
    {
        [FieldProperty]
        CommonInterface Common { get; set; }
        [FieldProperty]
        AomapInterface Aomap { get; set; }
        [FieldProperty]
        LightmapInterface Lightmap { get; set; }
        [FieldProperty]
        EmissivemapInterface Emissivemap { get; set; }
        [FieldProperty]
        BumpmapInterface Bumpmap { get; set; }
        [FieldProperty]
        NormalmapInterface Normalmap { get; set; }
        [FieldProperty]
        DisplacementmapInterface Displacementmap { get; set; }
        [FieldProperty]
        RoughnessmapInterface Roughnessmap { get; set; }
        [FieldProperty]
        MetalnessmapInterface Metalnessmap { get; set; }
        [FieldProperty]
        FogInterface Fog { get; set; }
        [FieldProperty]
        LightsInterface Lights { get; set; }
        [FieldProperty]
        PointsInterface Points { get; set; }
    }
    [External]
    public class Uniform
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Function OnUpdateCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Uniform(string type, string value);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Uniform OnUpdate(Function callback);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLBufferRenderer
    {
#pragma warning disable CS0824
        public extern WebGLBufferRenderer(WebGLRenderingContext _gl, any extensions, any _infoRender);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetMode(any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(any start, any count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderInstances(any geometry);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONWebGLCapabilitiesParameters : WebGLCapabilitiesParameters
    {
#pragma warning disable CS0626
        public extern any Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any LogarithmicDepthBuffer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WebGLCapabilitiesParameters
    {
        [FieldProperty]
        any Precision { get; set; }
        [FieldProperty]
        any LogarithmicDepthBuffer { get; set; }
    }
    [External]
    public class WebGLCapabilities
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any LogarithmicDepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxVertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxTextureSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxCubemapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxAttributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxVertexUniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxVaryings { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any MaxFragmentUniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any VertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any FloatFragmentTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any FloatVertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLCapabilities(WebGLRenderingContext gl, any extensions, WebGLCapabilitiesParameters parameters);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any GetMaxPrecision(any precision);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLExtensions
    {
#pragma warning disable CS0824
        public extern WebGLExtensions(WebGLRenderingContext gl);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Get(string name);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLGeometries
    {
#pragma warning disable CS0824
        public extern WebGLGeometries(WebGLRenderingContext gl, any extensions, any _infoRender);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Get(any @object);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLLights
    {
#pragma warning disable CS0824
        public extern WebGLLights(WebGLRenderingContext gl, any properties, any info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Get(any light);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLIndexedBufferRenderer
    {
#pragma warning disable CS0824
        public extern WebGLIndexedBufferRenderer(WebGLRenderingContext gl, any properties, any info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetMode(any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetIndex(any index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(any start, number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderInstances(any geometry, any start, number count);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLObjects
    {
#pragma warning disable CS0824
        public extern WebGLObjects(WebGLRenderingContext gl, any properties, any info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any GetAttributeBuffer(any attribute);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetWireframeAttribute(any geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update(any @object);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLProgram
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Code { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number UsedTimes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Program { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLShader VertexShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLShader FragmentShader { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Uniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Attributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLProgram(WebGLRenderer renderer, string code, ShaderMaterial material, WebGLRendererParameters parameters);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any GetUniforms();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetAttributes();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Destroy();
#pragma warning restore CS0626
    }
    [External]
    public class WebGLPrograms
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any[] Programs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLPrograms(WebGLRenderer renderer, any capabilities);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any[] GetParameters(ShaderMaterial material, any lights, any fog, any @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetProgramCode(ShaderMaterial material, any parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern WebGLProgram AcquireProgram(ShaderMaterial material, any parameters, string code);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ReleaseProgram(WebGLProgram program);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLProperties
    {
#pragma warning disable CS0824
        public extern WebGLProperties();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern any Get(any @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Delete(any @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Clear();
#pragma warning restore CS0626
    }
    [External]
    public class WebGLShader
    {
#pragma warning disable CS0824
        public extern WebGLShader(any gl, string type, string @string);
#pragma warning restore CS0824
    }
    [External]
    public class WebGLShadowMap
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Enabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ShadowMapType Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern CullFace CullFace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLShadowMap(Renderer _renderer, any[] _lights, any[] _objects);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLState
    {
#pragma warning disable CS0824
        public extern WebGLState(any gl, any extensions, Function paramThreeToGL);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Init();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void InitAttributes();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void EnableAttribute(string attribute);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void EnableAttributeAndDivisor(string attribute, any meshPerAttribute, any extension);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void DisableUnusedAttributes();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Enable(string id);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Disable(string id);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any[] GetCompressedTextureFormats();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetBlending(number blending, number blendEquation, number blendSrc, number blendDst, number blendEquationAlpha, number blendSrcAlpha, number blendDstAlpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthFunc(Function func);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthTest(number depthTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthWrite(number depthWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetColorWrite(number colorWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilFunc(Function stencilFunc, any stencilRef, any stencilMask);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilOp(any stencilFail, any stencilZFail, any stencilZPass);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilTest(boolean stencilTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilWrite(any stencilWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFlipSided(number flipSided);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLineWidth(number width);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPolygonOffset(number polygonoffset, number factor, number units);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissorTest(boolean scissorTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean GetScissorTest();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ActiveTexture(any webglSlot);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void BindTexture(any webglType, any webglTexture);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void CompressedTexImage2D();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TexImage2D();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearColor(number r, number g, number b, number a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearDepth(number depth);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearStencil(any stencil);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Scissor(any scissor);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Viewport(any viewport);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Reset();
#pragma warning restore CS0626
    }
    [External]
    public class LensFlarePlugin
    {
#pragma warning disable CS0824
        public extern LensFlarePlugin(WebGLRenderer renderer, any[] flares);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, number viewportWidth, number viewportHeight);
#pragma warning restore CS0626
    }
    [External]
    public class SpritePlugin
    {
#pragma warning disable CS0824
        public extern SpritePlugin(WebGLRenderer renderer, any[] sprites);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, number viewportWidth, number viewportHeight);
#pragma warning restore CS0626
    }
    [External]
    public class Scene : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern IFog Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material OverrideMaterial { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Scene();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Scene Copy(Scene source, boolean recursive = default(boolean));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONIFog : IFog
    {
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Color { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate IFog cloneDelegate();

#pragma warning disable CS0626
        public extern IFog Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern cloneDelegate clone { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface IFog
    {
        [FieldProperty]
        string Name { get; set; }
        [FieldProperty]
        Color Color { get; set; }
        IFog Clone();
    }
    [External]
    public class Fog : IFog
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Fog(number hex, number near = default(number), number far = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Fog Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern IFog IFog.Clone();
#pragma warning restore CS0626
    }
    [External]
    public class FogExp2 : IFog
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Density { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern FogExp2(Any<number, string> hex, number density = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern FogExp2 Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern IFog IFog.Clone();
#pragma warning restore CS0626
    }
    [External]
    public delegate void onUpdateDelegate();
    [External]
    public delegate void addEventListenerParam2Delegate6(Event @event);
    [External]
    public delegate void hasEventListenerParam2Delegate6(Event @event);
    [External]
    public delegate void removeEventListenerParam2Delegate6(Event @event);
    [External]
    public class Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string SourceFile { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Image { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ImageData[] Mipmaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Mapping Mapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Wrapping WrapS { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Wrapping WrapT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TextureFilter MagFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TextureFilter MinFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Anisotropy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern PixelFormat Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TextureDataType Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 Repeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean GenerateMipmaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean PremultiplyAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean FlipY { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number UnpackAlignment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TextureEncoding Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onUpdateDelegate OnUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static any DEFAULT_IMAGE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static any DEFAULT_MAPPING { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Texture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> image, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Texture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Copy(Texture source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any ToJSON(any meta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TransformUv(Vector uv);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam2Delegate6 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam2Delegate6 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam2Delegate6 listener);
#pragma warning restore CS0626
    }
    [External]
    public class CanvasTexture : Texture
    {
#pragma warning disable CS0824
        public extern CanvasTexture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> canvas, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern CanvasTexture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern CanvasTexture Copy(CanvasTexture source);
#pragma warning restore CS0626
    }
    [External]
    public class CubeTexture : Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Images { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubeTexture(any[] images = default(any[]), Mapping apping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern CubeTexture Copy(CubeTexture source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONImageInterface : ImageInterface
    {
#pragma warning disable CS0626
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ImageInterface
    {
        [FieldProperty]
        number Width { get; set; }
        [FieldProperty]
        number Height { get; set; }
    }
    [External]
    public class CompressedTexture : Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ImageInterface Image { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CompressedTexture(ImageData[] mipmaps, number width, number height, PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern CompressedTexture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern CompressedTexture Copy(CompressedTexture source);
#pragma warning restore CS0626
    }
    [External]
    public class DataTexture : Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ImageInterface Image { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DataTexture(Any<Any<ArrayBuffer, Int8Array, Uint8Array>, Uint8ClampedArray, Int16Array, Uint16Array, Int32Array, Uint32Array, Float32Array, Float64Array> data, number width, number height, PixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern DataTexture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DataTexture Copy(DataTexture source);
#pragma warning restore CS0626
    }
    [External]
    public class VideoTexture : Texture
    {
#pragma warning disable CS0824
        public extern VideoTexture(HTMLVideoElement video, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), number anisotropy = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern VideoTexture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern VideoTexture Copy(VideoTexture source);
#pragma warning restore CS0626
    }
    [External]
    public class Audio : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern AudioContext Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern AudioBufferSourceNode Source { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern GainNode Gain { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Autoplay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number StartTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number PlaybackRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean HasPlaybackControl { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean IsPlaying { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string SourceType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Filter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Audio(AudioListener listener);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern GainNode GetOutput();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Audio Load(string file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Audio SetNodeSource(AudioBufferSourceNode audioNode);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Audio SetBuffer(AudioBuffer audioBuffer);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Play();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Pause();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Stop();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Connect();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Disconnect();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFilter(any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetFilter();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPlaybackRate(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetPlaybackRate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnEnded();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLoop(boolean value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean GetLoop();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetVolume(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetVolume();
#pragma warning restore CS0626
    }
    [External]
    public class AudioAnalyser
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Analyser { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Uint8Array Data { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AudioAnalyser(any audio, number fftSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Uint8Array GetData();
#pragma warning restore CS0626
    }
    [External]
    public class AudioBuffer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean Ready { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Function[] ReadyCallbacks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AudioBuffer(any context);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern AudioBuffer Load(string file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnReady(Function callback);
#pragma warning restore CS0626
    }
    [External]
    public class PositionalAudio : Audio
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern PannerNode Panner { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PositionalAudio(AudioListener listener);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetRefDistance(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetRefDistance();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRolloffFactor(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetRolloffFactor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDistanceModel(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetDistanceModel();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetMaxDistance(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetMaxDistance();
#pragma warning restore CS0626
    }
    [External]
    public class AudioListener : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern AudioContext Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern GainNode Gain { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AudioListener();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern GainNode GetInput();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveFilter();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFilter(any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any GetFilter();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetMasterVolume(number value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetMasterVolume();
#pragma warning restore CS0626
    }
    [External]
    public class Curve<T> where T : Vector
    {
#pragma warning disable CS0626
        public extern T GetPoint(number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetPointAt(number u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T[] GetPoints(number divisions = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T[] GetSpacedPoints(number divisions = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetLength();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] GetLengths(number divisions = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateArcLengths();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetUtoTmapping(number u, number distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetTangent(number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetTangentAt(number u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Function Create(Function constructorFunc, Function getPointFunc);
#pragma warning restore CS0626
#pragma warning disable CS0824
        extern Curve();
#pragma warning restore CS0824
    }
    [External]
    public class CurvePath<T> : Curve<T> where T : Vector
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Curve<T>[] Curves { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AutoClose { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CurvePath();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(Curve<T> curve);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean CheckConnection();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClosePath();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetPoint(number t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetLength();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number[] GetCurveLengths();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry CreatePointsGeometry(number divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry CreateSpacedPointsGeometry(number divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry CreateGeometry(T[] points);
#pragma warning restore CS0626
    }
    [External]
    public enum PathActions
    {
        MOVE_TO,
        LINE_TO,
        QUADRATIC_CURVE_TO,
        ZIER_CURVE_TO,
        PLINE_THRU,
        C,
        LIPSE,

    }
    [ObjectLiteral]
    public class JSONPathAction : PathAction
    {
#pragma warning disable CS0626
        public extern PathActions Action { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern any Args { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PathAction
    {
        [FieldProperty]
        PathActions Action { get; set; }
        [FieldProperty]
        any Args { get; set; }
    }
    [External]
    public class Path : CurvePath<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern PathAction[] Actions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Path(Vector2[] points = default(Vector2[]));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void FromPoints(Vector2[] vectors);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void MoveTo(number x, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LineTo(number x, number y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void QuadraticCurveTo(number aCPx, number aCPy, number aX, number aY);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void BezierCurveTo(number aCP1x, number aCP1y, number aCP2x, number aCP2y, number aX, number aY);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SplineThru(Vector2[] pts);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Arc(number aX, number aY, number aRadius, number aStartAngle, number aEndAngle, boolean aClockwise);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Absarc(number aX, number aY, number aRadius, number aStartAngle, number aEndAngle, boolean aClockwise);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Ellipse(number aX, number aY, number xRadius, number yRadius, number aStartAngle, number aEndAngle, boolean aClockwise, number aRotation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Absellipse(number aX, number aY, number xRadius, number yRadius, number aStartAngle, number aEndAngle, boolean aClockwise, number aRotation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] GetSpacedPoints(number divisions = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] GetPoints(number divisions = default(number), boolean closedPath = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shape[] ToShapes(boolean isCCW, any noHoles);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONExtractAllPointsInterface : ExtractAllPointsInterface
    {
#pragma warning disable CS0626
        public extern Vector2[] Shape { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[][] Holes { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ExtractAllPointsInterface
    {
        [FieldProperty]
        Vector2[] Shape { get; set; }
        [FieldProperty]
        Vector2[][] Holes { get; set; }
    }
    [External]
    public class Shape : Path
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Path[] Holes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Shape(Vector2[] points = default(Vector2[]));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern ExtrudeGeometry Extrude(any options = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShapeGeometry MakeGeometry(any options = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[][] GetPointsHoles(number divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ExtractAllPointsInterface ExtractAllPoints(number divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] ExtractPoints(number divisions);
#pragma warning restore CS0626
    }
    [External]
    public class CatmullRomCurve3 : Curve<Vector3>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CatmullRomCurve3(Vector3[] points = default(Vector3[]));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 GetPoint(number t);
#pragma warning restore CS0626
    }
    [External]
    public class ClosedSplineCurve3 : CatmullRomCurve3
    {
#pragma warning disable CS0824
        extern ClosedSplineCurve3();
#pragma warning restore CS0824
    }
    [External]
    public class SplineCurve3 : CatmullRomCurve3
    {
#pragma warning disable CS0824
        extern SplineCurve3();
#pragma warning restore CS0824
    }
    [External]
    public class CubicBezierCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V0 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V3 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubicBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3);
#pragma warning restore CS0824
    }
    [External]
    public class CubicBezierCurve3 : Curve<Vector3>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V0 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V3 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubicBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 GetPoint(number t);
#pragma warning restore CS0626
    }
    [External]
    public class EllipseCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AX { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AY { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number XRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number YRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AStartAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number AEndAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern boolean AClockwise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number ARotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern EllipseCurve(number aX, number aY, number xRadius, number yRadius, number aStartAngle, number aEndAngle, boolean aClockwise, number aRotation);
#pragma warning restore CS0824
    }
    [External]
    public class ArcCurve : EllipseCurve
    {
#pragma warning disable CS0824
        public extern ArcCurve(number aX, number aY, number aRadius, number aStartAngle, number aEndAngle, boolean aClockwise);
#pragma warning restore CS0824
    }
    [External]
    public class LineCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LineCurve(Vector2 v1, Vector2 v2);
#pragma warning restore CS0824
    }
    [External]
    public class LineCurve3 : Curve<Vector3>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LineCurve3(Vector3 v1, Vector3 v2);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 GetPoint(number t);
#pragma warning restore CS0626
    }
    [External]
    public class QuadraticBezierCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V0 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern QuadraticBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2);
#pragma warning restore CS0824
    }
    [External]
    public class QuadraticBezierCurve3 : Curve<Vector3>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V0 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3 V2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern QuadraticBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 GetPoint(number t);
#pragma warning restore CS0626
    }
    [External]
    public class SplineCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector2[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SplineCurve(Vector2[] points = default(Vector2[]));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface : ParametersInterface
    {
#pragma warning disable CS0626
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Depth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number DepthSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface
    {
        [FieldProperty]
        number Width { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number Depth { get; set; }
        [FieldProperty]
        number WidthSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
        [FieldProperty]
        number DepthSegments { get; set; }
    }
    [External]
    public class BoxBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BoxBufferGeometry(number width, number height, number depth, number widthSegments = default(number), number heightSegments = default(number), number depthSegments = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class BoxGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BoxGeometry(number width, number height, number depth, number widthSegments = default(number), number heightSegments = default(number), number depthSegments = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern BoxGeometry Clone();
#pragma warning restore CS0626
    }
    [External]
    public class CubeGeometry : BoxGeometry
    {
#pragma warning disable CS0824
        extern CubeGeometry();
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface1 : ParametersInterface1
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface1
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Segments { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class CircleBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface1 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CircleBufferGeometry(number radius = default(number), number segments = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface2 : ParametersInterface2
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface2
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Segments { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class CircleGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface2 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CircleGeometry(number radius = default(number), number segments = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface3 : ParametersInterface3
    {
#pragma warning disable CS0626
        public extern number RadiusTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadiusBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean OpenEnded { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface3
    {
        [FieldProperty]
        number RadiusTop { get; set; }
        [FieldProperty]
        number RadiusBottom { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
        [FieldProperty]
        boolean OpenEnded { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class CylinderBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface3 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CylinderBufferGeometry(number radiusTop = default(number), number radiusBottom = default(number), number height = default(number), number radialSegments = default(number), number heightSegments = default(number), boolean openEnded = default(boolean), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface4 : ParametersInterface4
    {
#pragma warning disable CS0626
        public extern number RadiusTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadiusBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean OpenEnded { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface4
    {
        [FieldProperty]
        number RadiusTop { get; set; }
        [FieldProperty]
        number RadiusBottom { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
        [FieldProperty]
        boolean OpenEnded { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class CylinderGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface4 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CylinderGeometry(number radiusTop = default(number), number radiusBottom = default(number), number height = default(number), number radiusSegments = default(number), number heightSegments = default(number), boolean openEnded = default(boolean), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface5 : ParametersInterface5
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Detail { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface5
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Detail { get; set; }
    }
    [External]
    public class DodecahedronGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface5 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DodecahedronGeometry(number radius, number detail);
#pragma warning restore CS0824
    }
    [External]
    public class EdgesGeometry : BufferGeometry
    {
#pragma warning disable CS0824
        public extern EdgesGeometry(BufferGeometry geometry, number thresholdAngle);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern EdgesGeometry Clone();
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONWorldUVGeneratorInterface : WorldUVGeneratorInterface
    {
        [External]
        public delegate Vector2[] generateTopUVDelegate(Geometry geometry, number indexA, number indexB, number indexC);

#pragma warning disable CS0626
        public extern Vector2[] GenerateTopUV(Geometry geometry, number indexA, number indexB, number indexC);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern generateTopUVDelegate generateTopUV { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector2[] generateSideWallUVDelegate(Geometry geometry, number indexA, number indexB, number indexC, number indexD);

#pragma warning disable CS0626
        public extern Vector2[] GenerateSideWallUV(Geometry geometry, number indexA, number indexB, number indexC, number indexD);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern generateSideWallUVDelegate generateSideWallUV { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WorldUVGeneratorInterface
    {
        Vector2[] GenerateTopUV(Geometry geometry, number indexA, number indexB, number indexC);
        Vector2[] GenerateSideWallUV(Geometry geometry, number indexA, number indexB, number indexC, number indexD);
    }
    [External]
    public class ExtrudeGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        [Name(false)]
        public extern static WorldUVGeneratorInterface WorldUVGenerator { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ExtrudeGeometry(Shape shape = default(Shape), any options = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern ExtrudeGeometry(Shape[] shapes = default(Shape[]), any options = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddShapeList(Shape[] shapes, any options = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddShape(Shape shape, any options = default(any));
#pragma warning restore CS0626
    }
    [External]
    public class IcosahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern IcosahedronGeometry(number radius, number detail);
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface6 : ParametersInterface6
    {
#pragma warning disable CS0626
        public extern Vector3[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface6
    {
        [FieldProperty]
        Vector3[] Points { get; set; }
        [FieldProperty]
        number Segments { get; set; }
        [FieldProperty]
        number PhiStart { get; set; }
        [FieldProperty]
        number PhiLength { get; set; }
    }
    [External]
    public class LatheBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface6 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LatheBufferGeometry(Vector3[] points, number segments = default(number), number phiStart = default(number), number phiLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface7 : ParametersInterface7
    {
#pragma warning disable CS0626
        public extern Vector3[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface7
    {
        [FieldProperty]
        Vector3[] Points { get; set; }
        [FieldProperty]
        number Segments { get; set; }
        [FieldProperty]
        number PhiStart { get; set; }
        [FieldProperty]
        number PhiLength { get; set; }
    }
    [External]
    public class LatheGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface7 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LatheGeometry(Vector3[] points, number segments = default(number), number phiStart = default(number), number phiLength = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class OctahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern OctahedronGeometry(number radius, number detail);
#pragma warning restore CS0824
    }
    [External]
    public delegate Vector3 funcDelegate(number u, number v);
    [ObjectLiteral]
    public class JSONParametersInterface8 : ParametersInterface8
    {
#pragma warning disable CS0626
        public extern funcDelegate Func { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Slices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Stacks { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface8
    {
        [FieldProperty]
        funcDelegate Func { get; set; }
        [FieldProperty]
        number Slices { get; set; }
        [FieldProperty]
        number Stacks { get; set; }
    }
    [External]
    public class ParametricGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface8 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ParametricGeometry(constructorParam1Delegate func, number slices, number stacks);
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface9 : ParametersInterface9
    {
#pragma warning disable CS0626
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface9
    {
        [FieldProperty]
        number Width { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number WidthSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
    }
    [External]
    public class PlaneBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface9 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PlaneBufferGeometry(number width, number height, number widthSegments = default(number), number heightSegments = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac10 : ParametersInterfac10
    {
#pragma warning disable CS0626
        public extern number Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac10
    {
        [FieldProperty]
        number Width { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number WidthSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
    }
    [External]
    public class PlaneGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac10 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PlaneGeometry(number width, number height, number widthSegments = default(number), number heightSegments = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac11 : ParametersInterfac11
    {
#pragma warning disable CS0626
        public extern Vector3[] Vertices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Face3[] Faces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Detail { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac11
    {
        [FieldProperty]
        Vector3[] Vertices { get; set; }
        [FieldProperty]
        Face3[] Faces { get; set; }
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Detail { get; set; }
    }
    [External]
    public class PolyhedronGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac11 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Sphere BoundingSphere { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PolyhedronGeometry(Vector3[] vertices, Face3[] faces, number radius = default(number), number detail = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac12 : ParametersInterfac12
    {
#pragma warning disable CS0626
        public extern number InnerRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number OuterRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac12
    {
        [FieldProperty]
        number InnerRadius { get; set; }
        [FieldProperty]
        number OuterRadius { get; set; }
        [FieldProperty]
        number ThetaSegments { get; set; }
        [FieldProperty]
        number PhiSegments { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class RingBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac12 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern RingBufferGeometry(number innerRadius = default(number), number outerRadius = default(number), number thetaSegments = default(number), number phiSegments = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac13 : ParametersInterfac13
    {
#pragma warning disable CS0626
        public extern number InnerRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number OuterRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac13
    {
        [FieldProperty]
        number InnerRadius { get; set; }
        [FieldProperty]
        number OuterRadius { get; set; }
        [FieldProperty]
        number ThetaSegments { get; set; }
        [FieldProperty]
        number PhiSegments { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class RingGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac13 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern RingGeometry(number innerRadius = default(number), number outerRadius = default(number), number thetaSegments = default(number), number phiSegments = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class ShapeGeometry : Geometry
    {
#pragma warning disable CS0824
        public extern ShapeGeometry(Shape shape, any options = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern ShapeGeometry(Shape[] shapes, any options = default(any));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern ShapeGeometry AddShapeList(Shape[] shapes, any options);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddShape(Shape shape, any options = default(any));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONParametersInterfac14 : ParametersInterfac14
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac14
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number WidthSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
        [FieldProperty]
        number PhiStart { get; set; }
        [FieldProperty]
        number PhiLength { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class SphereBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac14 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SphereBufferGeometry(number radius, number widthSegments = default(number), number heightSegments = default(number), number phiStart = default(number), number phiLength = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac15 : ParametersInterfac15
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number PhiLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac15
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number WidthSegments { get; set; }
        [FieldProperty]
        number HeightSegments { get; set; }
        [FieldProperty]
        number PhiStart { get; set; }
        [FieldProperty]
        number PhiLength { get; set; }
        [FieldProperty]
        number ThetaStart { get; set; }
        [FieldProperty]
        number ThetaLength { get; set; }
    }
    [External]
    public class SphereGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac15 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SphereGeometry(number radius, number widthSegments = default(number), number heightSegments = default(number), number phiStart = default(number), number phiLength = default(number), number thetaStart = default(number), number thetaLength = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class TetrahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern TetrahedronGeometry(number radius = default(number), number detail = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONTextGeometryParameters : TextGeometryParameters
    {
#pragma warning disable CS0626
        public extern Font Font { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number CurveSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean BevelEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BevelThickness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BevelSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface TextGeometryParameters
    {
        [FieldProperty]
        Font Font { get; set; }
        [FieldProperty]
        number Size { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number CurveSegments { get; set; }
        [FieldProperty]
        boolean BevelEnabled { get; set; }
        [FieldProperty]
        number BevelThickness { get; set; }
        [FieldProperty]
        number BevelSize { get; set; }
    }
    [ObjectLiteral]
    public class JSONParametersInterfac16 : ParametersInterfac16
    {
#pragma warning disable CS0626
        public extern Font Font { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number CurveSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean BevelEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BevelThickness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number BevelSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac16
    {
        [FieldProperty]
        Font Font { get; set; }
        [FieldProperty]
        number Size { get; set; }
        [FieldProperty]
        number Height { get; set; }
        [FieldProperty]
        number CurveSegments { get; set; }
        [FieldProperty]
        boolean BevelEnabled { get; set; }
        [FieldProperty]
        number BevelThickness { get; set; }
        [FieldProperty]
        number BevelSize { get; set; }
    }
    [External]
    public class TextGeometry : ExtrudeGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac16 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TextGeometry(string text, TextGeometryParameters parameters = default(TextGeometryParameters));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac17 : ParametersInterfac17
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Arc { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac17
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Tube { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number TubularSegments { get; set; }
        [FieldProperty]
        number Arc { get; set; }
    }
    [External]
    public class TorusBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac17 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusBufferGeometry(number radius = default(number), number tube = default(number), number radialSegments = default(number), number tubularSegments = default(number), number arc = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac18 : ParametersInterfac18
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Arc { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac18
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Tube { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number TubularSegments { get; set; }
        [FieldProperty]
        number Arc { get; set; }
    }
    [External]
    public class TorusGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac18 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusGeometry(number radius = default(number), number tube = default(number), number radialSegments = default(number), number tubularSegments = default(number), number arc = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac19 : ParametersInterfac19
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number P { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Q { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac19
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Tube { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number TubularSegments { get; set; }
        [FieldProperty]
        number P { get; set; }
        [FieldProperty]
        number Q { get; set; }
        [FieldProperty]
        number HeightScale { get; set; }
    }
    [External]
    public class TorusKnotBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac19 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusKnotBufferGeometry(number radius = default(number), number tube = default(number), number radialSegments = default(number), number tubularSegments = default(number), number p = default(number), number q = default(number), number heightScale = default(number));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac20 : ParametersInterfac20
    {
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number P { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Q { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number HeightScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac20
    {
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number Tube { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        number TubularSegments { get; set; }
        [FieldProperty]
        number P { get; set; }
        [FieldProperty]
        number Q { get; set; }
        [FieldProperty]
        number HeightScale { get; set; }
    }
    [External]
    public class TorusKnotGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac20 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusKnotGeometry(number radius = default(number), number tube = default(number), number radialSegments = default(number), number tubularSegments = default(number), number p = default(number), number q = default(number), number heightScale = default(number));
#pragma warning restore CS0824
    }
    [External]
    public delegate number constructorParam6Delegate(number u);
    [External]
    public delegate number taperDelegate(number u);
    [ObjectLiteral]
    public class JSONParametersInterfac21 : ParametersInterfac21
    {
#pragma warning disable CS0626
        public extern Path Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Closed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern taperDelegate Taper { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac21
    {
        [FieldProperty]
        Path Path { get; set; }
        [FieldProperty]
        number Segments { get; set; }
        [FieldProperty]
        number Radius { get; set; }
        [FieldProperty]
        number RadialSegments { get; set; }
        [FieldProperty]
        boolean Closed { get; set; }
        [FieldProperty]
        taperDelegate Taper { get; set; }
    }
    [External]
    public class TubeGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac21 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Tangents { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Normals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector3[] Binormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TubeGeometry(Path path, number segments = default(number), number radius = default(number), number radiusSegments = default(number), boolean closed = default(boolean), constructorParam6Delegate taper = default(constructorParam6Delegate));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern static number NoTaper(number u = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static number SinusoidalTaper(number u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void FrenetFrames(Path path, number segments, boolean closed);
#pragma warning restore CS0626
    }
    [External]
    public class WireframeGeometry : BufferGeometry
    {
#pragma warning disable CS0824
        public extern WireframeGeometry(Any<Geometry, BufferGeometry> geometry);
#pragma warning restore CS0824
    }
    [External]
    public class ArrowHelper : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Line Line { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Mesh Cone { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ArrowHelper(Vector3 dir, Vector3 origin = default(Vector3), number length = default(number), number hex = default(number), number headLength = default(number), number headWidth = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetDirection(Vector3 dir);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLength(number length, number headLength = default(number), number headWidth = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetColor(number hex);
#pragma warning restore CS0626
    }
    [External]
    public class AxisHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern AxisHelper(number size = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class BoundingBoxHelper : Mesh
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Object { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Box3 Box { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BoundingBoxHelper(Object3D @object = default(Object3D), number hex = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class BoxHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern BoxHelper(Object3D @object = default(Object3D));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update(Object3D @object = default(Object3D));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONPointMapInterface : PointMapInterface
    {
        [External]
        public delegate number[] PointMapInterfaceIndexerDelegate(string id);

#pragma warning disable CS0626
        public extern number[] this[string id] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointMapInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointMapInterface
    {
        number[] this[string id] { get; set; }
    }
    [External]
    public class CameraHelper : LineSegments
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Camera Camera { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern PointMapInterface PointMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CameraHelper(Camera camera);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class DirectionalLightHelper : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Light Light { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Line LightPlane { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Line TargetLine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DirectionalLightHelper(Light light, number size = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class EdgesHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern EdgesHelper(Object3D @object, number hex = default(number), number thresholdAngle = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class FaceNormalsHelper : LineSegments
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Object { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern FaceNormalsHelper(Object3D @object, number size = default(number), number hex = default(number), number linewidth = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update(Object3D @object = default(Object3D));
#pragma warning restore CS0626
    }
    [External]
    public class GridHelper : LineSegments
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color1 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Color2 { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern GridHelper(number size, number step);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetColors(number colorCenterLine, number colorGrid);
#pragma warning restore CS0626
    }
    [External]
    public class HemisphereLightHelper : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Light Light { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color[] Colors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Mesh LightSphere { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern HemisphereLightHelper(Light light, number sphereSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class PointLightHelper : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Light Light { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PointLightHelper(Light light, number sphereSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class SkeletonHelper : LineSegments
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Bone[] Bones { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Root { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SkeletonHelper(Object3D bone);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Bone[] GetBoneList(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class SpotLightHelper : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Light Light { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Mesh Cone { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SpotLightHelper(Light light, number sphereSize, number arrowLength);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update();
#pragma warning restore CS0626
    }
    [External]
    public class VertexNormalsHelper : LineSegments
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Object3D Object { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern number Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern VertexNormalsHelper(Object3D @object, number size = default(number), number hex = default(number), number linewidth = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update(Object3D @object = default(Object3D));
#pragma warning restore CS0626
    }
    [External]
    public class WireframeHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern WireframeHelper(Object3D @object, number hex = default(number));
#pragma warning restore CS0824
    }
    [External]
    public class ImmediateRenderObject : Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern Material Material { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ImmediateRenderObject(Material material);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Function renderCallback);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMorphBlendMeshAnimation : MorphBlendMeshAnimation
    {
#pragma warning disable CS0626
        public extern number Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number End { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Fps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number LastFrame { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number CurrentFrame { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean Active { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Time { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Direction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number Weight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean DirectionBackwards { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern boolean MirroredLoop { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MorphBlendMeshAnimation
    {
        [FieldProperty]
        number Start { get; set; }
        [FieldProperty]
        number End { get; set; }
        [FieldProperty]
        number Length { get; set; }
        [FieldProperty]
        number Fps { get; set; }
        [FieldProperty]
        number Duration { get; set; }
        [FieldProperty]
        number LastFrame { get; set; }
        [FieldProperty]
        number CurrentFrame { get; set; }
        [FieldProperty]
        boolean Active { get; set; }
        [FieldProperty]
        number Time { get; set; }
        [FieldProperty]
        number Direction { get; set; }
        [FieldProperty]
        number Weight { get; set; }
        [FieldProperty]
        boolean DirectionBackwards { get; set; }
        [FieldProperty]
        boolean MirroredLoop { get; set; }
    }
    [ObjectLiteral]
    public class JSONAnimationsMapInterface : AnimationsMapInterface
    {
        [External]
        public delegate MorphBlendMeshAnimation AnimationsMapInterfaceIndexerDelegate(string name);

#pragma warning disable CS0626
        public extern MorphBlendMeshAnimation this[string name] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationsMapInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface AnimationsMapInterface
    {
        MorphBlendMeshAnimation this[string name] { get; set; }
    }
    [External]
    public class MorphBlendMesh : Mesh
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern AnimationsMapInterface AnimationsMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern MorphBlendMeshAnimation[] AnimationsList { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern MorphBlendMesh(Geometry geometry, Material material);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void CreateAnimation(string name, number start, number end, number fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AutoCreateAnimations(number fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDirectionForward(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDirectionBackward(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationFPS(string name, number fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDuration(string name, number duration);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationWeight(string name, number weight);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationTime(string name, number time);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetAnimationTime(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern number GetAnimationDuration(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void PlayAnimation(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void StopAnimation(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update(number delta);
#pragma warning restore CS0626
    }

}