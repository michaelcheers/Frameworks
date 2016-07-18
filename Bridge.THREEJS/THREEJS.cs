using Bridge;
using System;
using Bridge.Html5;
using RegExp = Bridge.Text.RegularExpressions.Regex;
using number = System.Double;
using Number = System.Double;


namespace THREE.AnimationUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        public extern static object ArraySlice(object array, double from, double to);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object ConvertArray(object array, object type, bool forceClone);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static bool IsTypedArray(object @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double[] GetKeyFrameOrder(double times);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object[] SortedArray(object[] values, double stride, double[] order);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void FlattenJSON(string[] jsonKeys, object[] times, object[] values, string valuePropertyName);
#pragma warning restore CS0626
    }

}
namespace THREE.GeometryUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Ject3DIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static LoadingManager DefaultLoadingManager { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object Merge(object goemetry1, object goemetry2, object materialIndexOffset = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object Center(object geometry);
#pragma warning restore CS0626
    }

}
namespace THREE.Cache
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static bool Abled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static object Les { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double TerialIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Add(string key, object file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object Get(string key);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Remove(string key);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Clear();
#pragma warning restore CS0626
    }

}
namespace THREE.ColorKeywords
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Aliceblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Antiquewhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Aqua { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Aquamarine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Azure { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Beige { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Bisque { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Black { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Blanchedalmond { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Blue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Blueviolet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Brown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Burlywood { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Cadetblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Chartreuse { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Chocolate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Coral { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Cornflowerblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Cornsilk { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Crimson { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Cyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkcyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkgoldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkkhaki { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkmagenta { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkolivegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkorange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkorchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darksalmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkslateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkslategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkslategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Darkviolet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Deeppink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Deepskyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Dimgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Dimgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Dodgerblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Firebrick { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Floralwhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Forestgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Fuchsia { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Gainsboro { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Ghostwhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Gold { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Goldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Gray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Green { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Greenyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Grey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Honeydew { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Hotpink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Indianred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Indigo { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Ivory { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Khaki { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lavender { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lavenderblush { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lawngreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lemonchiffon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightcoral { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightcyan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightgoldenrodyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightgray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightgrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightpink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightsalmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightskyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightslategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightslategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightsteelblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lightyellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Lime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Limegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Linen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Magenta { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Maroon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumaquamarine { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumorchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumpurple { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumseagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumslateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumspringgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mediumvioletred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Midnightblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mintcream { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Mistyrose { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Moccasin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Navajowhite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Navy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Oldlace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Olive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Olivedrab { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Orange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Orangered { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Orchid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Palegoldenrod { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Palegreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Paleturquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Palevioletred { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Papayawhip { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Peachpuff { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Peru { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Pink { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Plum { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Powderblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Purple { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Red { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Rosybrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Royalblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Saddlebrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Salmon { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Sandybrown { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Seagreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Seashell { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Sienna { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Silver { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Skyblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Slateblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Slategray { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Slategrey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Snow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Springgreen { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Steelblue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Tan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Teal { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Thistle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Tomato { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Turquoise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Violet { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Wheat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double White { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Whitesmoke { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Yellow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double Yellowgreen { get; set; }
#pragma warning restore CS0626
    }

}
namespace THREE.Math
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static LineMode LineStrip { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static LineMode LinePieces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static AderChunkInterface AderChunk { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static AderLibInterface AderLib { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static IformsLibInterface IformsLib { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static string GenerateUUID();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double Clamp(double value, double min, double max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double EuclideanModulo(double n, double m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double MapLinear(double x, double a1, double a2, double b1, double b2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double Smoothstep(double x, double min, double max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double Smootherstep(double x, double min, double max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double Random16();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double RandInt(double low, double high);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double RandFloat(double low, double high);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double RandFloatSpread(double range);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double DegToRad(double degrees);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double RadToDeg(double radians);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static bool IsPowerOfTwo(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double NearestPowerOfTwo(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double NextPowerOfTwo(double value);
#pragma warning restore CS0626
    }

}
namespace THREE.UniformsUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double XtureIdCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object Merge(object[] uniforms);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object Clone(object uniforms_src);
#pragma warning restore CS0626
    }

}
namespace THREE.CurveUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        public extern static double TangentQuadraticBezier(double t, double p0, double p1, double p2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double TangentCubicBezier(double t, double p0, double p1, double p2, double p3);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double TangentSpline(double t, double p0, double p1, double p2, double p3);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double Interpolate(double p0, double p1, double p2, double p3, double t);
#pragma warning restore CS0626
    }

}
namespace THREE.ImageUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static string OssOrigin { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Texture LoadTexture(string url, Mapping mapping = default(Mapping), loadTextureParam21Delegate onLoad = default(loadTextureParam21Delegate), loadTextureParam31Delegate onError = default(loadTextureParam31Delegate));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Texture LoadTextureCube(string[] array, Mapping mapping = default(Mapping), loadTextureCubeParam21Delegate onLoad = default(loadTextureCubeParam21Delegate), loadTextureCubeParam31Delegate onError = default(loadTextureCubeParam31Delegate));
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadTextureParam21Delegate(Texture texture);
    [External]
    public delegate void loadTextureParam31Delegate(string message);
    [External]
    public delegate void loadTextureCubeParam21Delegate(Texture texture);
    [External]
    public delegate void loadTextureCubeParam31Delegate(string message);

}
namespace THREE.SceneUtils
{
    [External]
    public static class GlobalClass
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

}
namespace THREE.ShapeUtils
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        public extern static double Area(double[] contour);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector2[][] Triangulate(Vector2[] contour, bool indices);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector2[][] TriangulateShape(Vector2[] contour, Vector2[][] holes);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static bool IsClockWise(double[] pts);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double B2(double t, double p0, double p1, double p2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double B3(double t, double p0, double p1, double p2, double p3);
#pragma warning restore CS0626
    }

}
namespace THREE
{
    [External]
    public static class GlobalClass
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static string REVISION { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CullFace CullFaceNone { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CullFace CullFaceBack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CullFace CullFaceFront { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CullFace CullFaceFrontBack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static FrontFaceDirection FrontFaceDirectionCW { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static FrontFaceDirection FrontFaceDirectionCCW { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ShadowMapType BasicShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ShadowMapType PCFShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ShadowMapType PCFSoftShadowMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Side FrontSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Side BackSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Side DoubleSide { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Shading FlatShading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Shading SmoothShading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Colors NoColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Colors FaceColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending NoBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending NormalBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending AdditiveBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending SubtractiveBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending MultiplyBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Blending CustomBlending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingEquation AddEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingEquation SubtractEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingEquation ReverseSubtractEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingEquation MinEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingEquation MaxEquation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor ZeroFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor OneFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor SrcColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor OneMinusSrcColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor SrcAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor OneMinusSrcAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor DstAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingDstFactor OneMinusDstAlphaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingSrcFactor DstColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingSrcFactor OneMinusDstColorFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static BlendingSrcFactor SrcAlphaSaturateFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes NeverDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes AlwaysDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes LessDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes LessEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes EqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes GreaterEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes GreaterDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static DepthModes NotEqualDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Combine MultiplyOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Combine MixOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Combine AddOperation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ToneMapping NoToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ToneMapping LinearToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ToneMapping ReinhardToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ToneMapping Uncharted2ToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static ToneMapping CineonToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping UVMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping CubeReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping CubeRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping EquirectangularReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping EquirectangularRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping SphericalReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping CubeUVReflectionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Mapping CubeUVRefractionMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Wrapping RepeatWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Wrapping ClampToEdgeWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Wrapping MirroredRepeatWrapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter NearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter NearestMipMapNearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter NearestMipMapLinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter LinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter LinearMipMapNearestFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureFilter LinearMipMapLinearFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType UnsignedByteType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType ByteType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType ShortType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType UnsignedShortType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType IntType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType UnsignedIntType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType FloatType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureDataType HalfFloatType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelType UnsignedShort4444Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelType UnsignedShort5551Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelType UnsignedShort565Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat AlphaFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat RGBFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat RGBAFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat LuminanceFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat LuminanceAlphaFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static PixelFormat RGBEFormat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGB_S3TC_DXT1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT3_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGBA_S3TC_DXT5_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGB_PVRTC_4BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGB_PVRTC_2BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGBA_PVRTC_4BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGBA_PVRTC_2BPPV1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static CompressedPixelFormat RGB_ETC1_Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static AnimationActionLoopStyles LoopOnce { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static AnimationActionLoopStyles LoopRepeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static AnimationActionLoopStyles LoopPingPong { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationModes InterpolateDiscrete { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationModes InterpolateLinear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationModes InterpolateSmooth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationEndingModes ZeroCurvatureEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationEndingModes ZeroSlopeEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static InterpolationEndingModes WrapAroundEnding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TrianglesDrawModes TrianglesDrawModesMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TrianglesDrawModes TriangleStripDrawMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TrianglesDrawModes TriangleFanDrawMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding LinearEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding SRGBEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding GammaEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding RGBEEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding LogLuvEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding RGBM7Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding RGBM16Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static TextureEncoding RGBDEncoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Warn(object message = default(object), params object[] optionalParams);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Error(object message = default(object), params object[] optionalParams);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void Log(object message = default(object), params object[] optionalParams);
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
        public extern double Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object[] Results { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AnimationClip(string name = default(string), double duration = default(double), KeyframeTrack[] tracks = default(KeyframeTrack[]));
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
        public extern static AnimationClip CreateFromMorphTargetSequence(string name, MorphTarget[] morphTargetSequence, double fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip FindByName(AnimationClip clipArray, string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip[] CreateClipsFromMorphTargetSequences(MorphTarget[] morphTargets, double fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip Parse(object json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static AnimationClip ParseAnimation(object animation, Bone[] bones, string nodeName);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object ToJSON();
#pragma warning restore CS0626
    }
    [External]
    public class AnimationMixer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Time { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double TimeScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AnimationMixer(object root);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object ClipAction(AnimationClip clip, object root = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object ExistingAction(AnimationClip clip, object root = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationMixer StopAllAction(AnimationClip clip, object root = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationMixer Update(double deltaTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetRoot();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncacheClip(AnimationClip clip);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncacheRoot(object root);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UncazcheAction(AnimationClip clip, object root = default(object));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONObjectsInterface : ObjectsInterface
    {
#pragma warning disable CS0626
        public extern double Total { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double InUse { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ObjectsInterface
    {
        [FieldProperty]
        double Total { get; set; }
        [FieldProperty]
        double InUse { get; set; }
    }
    [ObjectLiteral]
    public class JSONStatsInterface : StatsInterface
    {
#pragma warning disable CS0626
        public extern double BindingsPerObject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ObjectsInterface Objects { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface StatsInterface
    {
        [FieldProperty]
        double BindingsPerObject { get; set; }
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
        public extern AnimationObjectGroup(params object[] args);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(params object[] args);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Remove(params object[] args);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Uncache(params object[] args);
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
        public extern object[] Times { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object[] Values { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string ValueTypeName { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Float32Array TimeBufferType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Float32Array ValueBufferType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern InterpolationModes DefaultInterpolation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern KeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern DiscreteInterpolant InterpolantFactoryMethodDiscrete(object result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern LinearInterpolant InterpolantFactoryMethodLinear(object result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern CubicInterpolant InterpolantFactoryMethodSmooth(object result);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetInterpolation(InterpolationModes interpolation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterpolationModes GetInterpolation();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetValuesize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Shift(double timeOffset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Scale(double timeScale);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Trim(double startTime, double endTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Validate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern KeyframeTrack Optimize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static KeyframeTrack Parse(object json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object ToJSON(KeyframeTrack track);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONBindingTypeInterface : BindingTypeInterface
    {
        [External]
        public delegate double BindingTypeInterfaceIndexerDelegate(string bindingType);

#pragma warning disable CS0626
        public extern double this[string bindingType] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BindingTypeInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface BindingTypeInterface
    {
        double this[string bindingType] { get; set; }
    }
    [ObjectLiteral]
    public class JSONVersioningInterface : VersioningInterface
    {
        [External]
        public delegate double VersioningInterfaceIndexerDelegate(string versioning);

#pragma warning disable CS0626
        public extern double this[string versioning] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern VersioningInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface VersioningInterface
    {
        double this[string versioning] { get; set; }
    }

    [External]
    public partial class PropertyBinding
    {
        [External]
        public static class GlobalClass
        {
#pragma warning disable CS0626
            [FieldProperty]
            public extern static double OmetryIdCount { get; set; }
#pragma warning restore CS0626
        }
        [External]
        public class Composite
        {
#pragma warning disable CS0824
            public extern Composite(object targetGroup, object path, object parsedPath = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
            public extern object GetValue(object array, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
            public extern void SetValue(object array, double offset);
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
    public partial class PropertyBinding
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ParsedPath { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Node { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object RootNode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern BindingTypeInterface BindingType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern VersioningInterface Versioning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate[] GetterByBindingType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate[][] SetterByBindingTypeAndVersioning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PropertyBinding(object rootNode, string path, object parsedPath = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object GetValue(object targetArray, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetValue(object sourceArray, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Bind();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Unbind();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static PropertyBinding Create(object root, object path, object parsedPath = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object ParseTrackName(string trackName);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static object FindNode(object root, string nodeName);
#pragma warning restore CS0626
    }
    [External]
    public class PropertyMixer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Binding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ValueSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Buffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double CumulativeWeight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double UseCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ReferenceCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PropertyMixer(object binding, string typeName, double valueSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Accumulate(double accuIndex, double weight);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Apply(double accuIndex);
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
        public extern BooleanKeyframeTrack(string name, object[] times, object[] values);
#pragma warning restore CS0824
    }
    [External]
    public class NumberKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern NumberKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class QuaternionKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern QuaternionKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class StringKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern StringKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation);
#pragma warning restore CS0824
    }
    [External]
    public class VectorKeyframeTrack : KeyframeTrack
    {
#pragma warning disable CS0824
        public extern VectorKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation);
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
        public extern CubeCamera(double near = default(double), double far = default(double), double cubeResolution = default(double));
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
        public extern double Zoom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Left { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Right { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Top { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Bottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern OrthographicCamera(double left, double right, double top, double bottom, double near = default(double), double far = default(double));
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
        public extern object ToJSON(object meta = default(object));
#pragma warning restore CS0626
    }
    [External]
    public class PerspectiveCamera : Camera
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double FocalLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Zoom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Fov { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Aspect { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PerspectiveCamera(double fov = default(double), double aspect = default(double), double near = default(double), double far = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetLens(double focalLength, double frameHeight = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetViewOffset(double fullWidth, double fullHeight, double x, double y, double width, double height);
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
        public extern object ToJSON(object meta = default(object));
#pragma warning restore CS0626
    }
    [External]
    public class StereoCamera : Camera
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Aspect { get; set; }
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
        public extern double Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Count { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface UpdateRangeInterface
    {
        [FieldProperty]
        double Offset { get; set; }
        [FieldProperty]
        double Count { get; set; }
    }
    [ObjectLiteral]
    public class JSONcolorsInterface : colorsInterface
    {
#pragma warning disable CS0626
        public extern double R { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double G { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double B { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface colorsInterface
    {
        [FieldProperty]
        double R { get; set; }
        [FieldProperty]
        double G { get; set; }
        [FieldProperty]
        double B { get; set; }
    }
    [ObjectLiteral]
    public class JSONindicesInterface : indicesInterface
    {
#pragma warning disable CS0626
        public extern double A { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double C { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface indicesInterface
    {
        [FieldProperty]
        double A { get; set; }
        [FieldProperty]
        double B { get; set; }
        [FieldProperty]
        double C { get; set; }
    }
    [ObjectLiteral]
    public class JSONvectorsInterface : vectorsInterface
    {
#pragma warning disable CS0626
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Y { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface vectorsInterface
    {
        [FieldProperty]
        double X { get; set; }
        [FieldProperty]
        double Y { get; set; }
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
        public extern double ItemSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern UpdateRangeInterface UpdateRange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BufferAttribute(ArrayLike<number> array, double itemSize);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern BufferAttribute SetDynamic(bool dynamic);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Copy(BufferAttribute source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute CopyAt(double index1, BufferAttribute attribute, double index2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute CopyArray(ArrayLike<number> array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute Set(ArrayLike<number> value, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetX(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetX(double index, double x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetY(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetY(double index, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetZ(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetZ(double index, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetW(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetW(double index, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXY(double index, double x, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXYZ(double index, double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute SetXYZW(double index, double x, double y, double z, double w);
#pragma warning restore CS0626
    }
    [External]
    public class Int8Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int8Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint8Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint8Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint8ClampedAttribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint8ClampedAttribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Int16Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int16Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint16Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint16Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Int32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Int32Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Uint32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Uint32Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Float32Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Float32Attribute(object array, double itemSize);
#pragma warning restore CS0824
    }
    [External]
    public class Float64Attribute : BufferAttribute
    {
#pragma warning disable CS0824
        public extern Float64Attribute(object array, double itemSize);
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
        public extern double Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double MaterialIndex { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GroupsInterface
    {
        [FieldProperty]
        double Start { get; set; }
        [FieldProperty]
        double Count { get; set; }
        [FieldProperty]
        double MaterialIndex { get; set; }
    }
    [ObjectLiteral]
    public class JSONDrawRangeInterface : DrawRangeInterface
    {
#pragma warning disable CS0626
        public extern double Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Count { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface DrawRangeInterface
    {
        [FieldProperty]
        double Start { get; set; }
        [FieldProperty]
        double Count { get; set; }
    }
    [External]
    public delegate void addEventListenerParam11Delegate(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate(Event @event);
    [ObjectLiteral]
    public class JSONeventInterface : eventInterface
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate object eventInterfaceIndexerDelegate(string attachment);

#pragma warning disable CS0626
        public extern object this[string attachment] { get; set; }
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
        object this[string attachment] { get; set; }
    }
    [External]
    public class BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static double MaxIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern object MorphAttributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Drawcalls { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Offsets { get; set; }
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
        public extern void AddGroup(double start, double count, double materialIndex = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearGroups();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDrawRange(double start, double count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry ApplyMatrix(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateX(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateY(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry RotateZ(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Translate(double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Scale(double x, double y, double z);
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
        public extern BufferGeometry FromGeometry(Geometry geometry, object settings = default(object));
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
        public extern BufferGeometry Merge(BufferGeometry geometry, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void NormalizeNormals();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry ToNonIndexed();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object ToJSON();
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
        public extern void AddEventListener(string type, addEventListenerParam11Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddIndex(object index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object AddAttribute(object name, object array, object itemSize);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddDrawCall(object start, object count, object indexOffset = default(object));
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
        public extern bool AutoStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double StartTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double OldTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ElapsedTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Running { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Clock(bool autoStart = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Start();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Stop();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetElapsedTime();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetDelta();
#pragma warning restore CS0626
    }
    [External]
    public class DirectGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern double[] Indices { get; set; }
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
        public extern double[] SkinWeights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double[] SkinIndices { get; set; }
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
        public extern bool VerticesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NormalsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ColorsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool UvsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool GroupsNeedUpdate { get; set; }
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
        public extern void AddEventListener(string type, addEventListenerParam11Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate listener);
#pragma warning restore CS0626
    }
    [External]
    public delegate void addEventListenerParam11Delegate1(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate1(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate1(Event @event);
    [External]
    public class EventDispatcher
    {
#pragma warning disable CS0824
        public extern EventDispatcher();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Apply(object @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam11Delegate1 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate1 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate1 listener);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONEvent : Event
    {
#pragma warning disable CS0626
        public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Target { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Event
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        object Target { get; set; }
    }
    [External]
    public class Face3
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double A { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double C { get; set; }
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
        public extern double MaterialIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Face3(double a, double b, double c, Vector3 normal = default(Vector3), Color color = default(Color), double materialIndex = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(double a, double b, double c, Vector3 normal = default(Vector3), Color[] vertexColors = default(Color[]), double materialIndex = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(double a, double b, double c, Vector3[] vertexNormals = default(Vector3[]), Color color = default(Color), double materialIndex = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Face3(double a, double b, double c, Vector3[] vertexNormals = default(Vector3[]), Color[] vertexColors = default(Color[]), double materialIndex = default(double));
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
        public extern double Radius { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface BoundingSphere
    {
        [FieldProperty]
        double Radius { get; set; }
    }
    [External]
    public delegate void addEventListenerParam11Delegate2(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate2(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate2(Event @event);
    [External]
    public class Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern double[] SkinWeights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double[] SkinIndices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double[] LineDistances { get; set; }
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
        public extern bool VerticesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ElementsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool UvsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NormalsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ColorsNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool LineDistancesNeedUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool GroupsNeedUpdate { get; set; }
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
        public extern Geometry RotateX(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry RotateY(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry RotateZ(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Translate(double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry Scale(double x, double y, double z);
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
        public extern void ComputeVertexNormals(bool areaWeighted = default(bool));
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
        public extern void Merge(Geometry geometry, Matrix matrix, double materialIndexOffset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void MergeMesh(Mesh mesh);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double MergeVertices();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SortFacesByMaterialIndex();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object ToJSON();
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
        public extern void AddEventListener(string type, addEventListenerParam11Delegate2 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate2 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate2 listener);
#pragma warning restore CS0626
    }
    [External]
    public class InstancedBufferAttribute : BufferAttribute
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double MeshPerAttribute { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedBufferAttribute(ArrayLike<number> data, double itemSize, double meshPerAttribute = default(double));
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
        public extern double Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Instances { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GroupsInterface1
    {
        [FieldProperty]
        double Start { get; set; }
        [FieldProperty]
        double Count { get; set; }
        [FieldProperty]
        double Instances { get; set; }
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
        public extern double MaxInstancedCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedBufferGeometry();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddGroup(double start, double count, double instances);
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
        public extern double Stride { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern UpdateRangeInterface UpdateRange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InterleavedBuffer(ArrayLike<number> array, double stride);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern InterleavedBuffer SetDynamic(bool dynamic);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Copy(InterleavedBuffer source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer CopyAt(double index1, InterleavedBufferAttribute attribute, double index2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBuffer Set(ArrayLike<number> value, double index);
#pragma warning restore CS0626
    }
    [External]
    public class InstancedInterleavedBuffer : InterleavedBuffer
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double MeshPerAttribute { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InstancedInterleavedBuffer(ArrayLike<number> array, double stride, double meshPerAttribute = default(double));
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
        public extern double ItemSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern InterleavedBufferAttribute(InterleavedBuffer interleavedBuffer, double itemSize, double offset);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern double GetX(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetX(double index, double x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetY(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetY(double index, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetZ(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetZ(double index, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetW(double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetW(double index, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXY(double index, double x, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXYZ(double index, double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern InterleavedBufferAttribute SetXYZW(double index, double x, double y, double z, double w);
#pragma warning restore CS0626
    }
    [External]
    public delegate object traverseParam01Delegate(Object3D @object);
    [External]
    public delegate object traverseVisibleParam01Delegate(Object3D @object);
    [External]
    public delegate object traverseAncestorsParam01Delegate(Object3D @object);
    [ObjectLiteral]
    public class JSONmetaInterface : metaInterface
    {
#pragma warning disable CS0626
        public extern object Geometries { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Materials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Textures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Images { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface metaInterface
    {
        [FieldProperty]
        object Geometries { get; set; }
        [FieldProperty]
        object Materials { get; set; }
        [FieldProperty]
        object Textures { get; set; }
        [FieldProperty]
        object Images { get; set; }
    }
    [External]
    public delegate void addEventListenerParam11Delegate3(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate3(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate3(Event @event);
    [External]
    public class Object3D
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern bool RotationAutoUpdate { get; set; }
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
        public extern bool MatrixAutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MatrixWorldNeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Layers Layers { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool CastShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ReceiveShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool FrustumCulled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double RenderOrder { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object UserData { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static Vector3 DefaultUp { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static bool DefaultMatrixAutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Object3D();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void ApplyMatrix(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRotationFromAxisAngle(Vector3 axis, double angle);
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
        public extern Object3D RotateOnAxis(Vector3 axis, double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateX(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateY(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D RotateZ(double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateOnAxis(Vector3 axis, double distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Translate(double distance, Vector3 axis);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateX(double distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateY(double distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D TranslateZ(double distance);
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
        public extern Object3D GetObjectById(double id);
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
        public extern void Raycast(Raycaster raycaster, object intersects);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Traverse(traverseParam01Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TraverseVisible(traverseVisibleParam01Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TraverseAncestors(traverseAncestorsParam01Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMatrix();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateMatrixWorld(bool force);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Clone(bool recursive = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Copy(Object3D source, bool recursive = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam11Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate3 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetChildByName(string name);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONIntersection : Intersection
    {
#pragma warning disable CS0626
        public extern double Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToRay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Point { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Index { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Face3 Face { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double FaceIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D Object { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface Intersection
    {
        [FieldProperty]
        double Distance { get; set; }
        [FieldProperty]
        double DistanceToRay { get; set; }
        [FieldProperty]
        Vector3 Point { get; set; }
        [FieldProperty]
        double Index { get; set; }
        [FieldProperty]
        Face3 Face { get; set; }
        [FieldProperty]
        double FaceIndex { get; set; }
        [FieldProperty]
        Object3D Object { get; set; }
    }
    [ObjectLiteral]
    public class JSONPointsInterface : PointsInterface
    {
#pragma warning disable CS0626
        public extern double Threshold { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointsInterface
    {
        [FieldProperty]
        double Threshold { get; set; }
    }
    [ObjectLiteral]
    public class JSONRaycasterParameters : RaycasterParameters
    {
#pragma warning disable CS0626
        public extern object Mesh { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Line { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object LOD { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointsInterface Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Sprite { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface RaycasterParameters
    {
        [FieldProperty]
        object Mesh { get; set; }
        [FieldProperty]
        object Line { get; set; }
        [FieldProperty]
        object LOD { get; set; }
        [FieldProperty]
        PointsInterface Points { get; set; }
        [FieldProperty]
        object Sprite { get; set; }
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
        public extern double Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern RaycasterParameters Params { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double LinePrecision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Raycaster(Vector3 origin = default(Vector3), Vector3 direction = default(Vector3), double near = default(double), double far = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(Vector3 origin, Vector3 direction);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Intersection[] IntersectObject(Object3D @object, bool recursive = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Intersection[] IntersectObjects(Object3D[] objects, bool recursive = default(bool));
#pragma warning restore CS0626
    }
    [External]
    public class Layers
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Mask { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Layers();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(double channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Enable(double channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Toggle(double channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Disable(double channel);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Test(Layers layers);
#pragma warning restore CS0626
    }
    [External]
    public class Font
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Data { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Font(object data);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object[] GenerateShapes(string text, double size, double divisions);
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
        public extern double Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ReceiveShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraFov { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraLeft { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraRight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraNear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowCameraFar { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowBias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowMapWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ShadowMapHeight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Light(Any<number, string> hex = default(Any<number, string>), double intensity = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Light Copy(Light source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Light Clone(bool recursive = default(bool));
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
        public extern double Bias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Radius { get; set; }
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
        public extern LightShadow Clone(bool recursive = default(bool));
#pragma warning restore CS0626
    }
    [External]
    public class AmbientLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool CastShadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AmbientLight(Any<number, string> hex = default(Any<number, string>), double intensity = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern AmbientLight Copy(AmbientLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AmbientLight Clone(bool recursive = default(bool));
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
        public extern double Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DirectionalLight(Any<number, string> hex = default(Any<number, string>), double intensity = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern DirectionalLight Copy(DirectionalLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HemisphereLight Clone(bool recursive = default(bool));
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
        public extern double Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern HemisphereLight(Any<number, string> skyColorHex = default(Any<number, string>), Any<number, string> groundColorHex = default(Any<number, string>), double intensity = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern HemisphereLight Copy(HemisphereLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern HemisphereLight Clone(bool recursive = default(bool));
#pragma warning restore CS0626
    }
    [External]
    public class PointLight : Light
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Decay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Power { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PointLight(Any<number, string> hex = default(Any<number, string>), double intensity = default(double), double distance = default(double), double decay = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern PointLight Copy(PointLight source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointLight Clone(bool recursive = default(bool));
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
        public extern double Intensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Angle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Exponent { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Decay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern LightShadow Shadow { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Power { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SpotLight(Any<number, string> hex = default(Any<number, string>), double intensity = default(double), double distance = default(double), double angle = default(double), double exponent = default(double), double decay = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern SpotLight Clone(bool recursive = default(bool));
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
        public extern bool CreateMaterial(Material m, string texturePath, string crossOrigin = default(string));
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
    public delegate void loadParam11Delegate(string responseText);
    [External]
    public delegate void loadParam21Delegate(object @event);
    [External]
    public delegate void loadParam31Delegate(object @event);
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
        public extern bool WithCredentials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern XHRLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Load(string url, loadParam11Delegate onLoad = default(loadParam11Delegate), loadParam21Delegate onProgress = default(loadParam21Delegate), loadParam31Delegate onError = default(loadParam31Delegate));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetResponseType(string responseType);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetWithCredentials(bool withCredentials);
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
        public extern void Load(string url, loadParam11Delegate onLoad = default(loadParam11Delegate), loadParam21Delegate onProgress = default(loadParam21Delegate), loadParam31Delegate onError = default(loadParam31Delegate));
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate1(HTMLImageElement image);
    [External]
    public delegate void loadParam21Delegate1(object @event);
    [External]
    public delegate void loadParam31Delegate1(object @event);
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
        public extern HTMLImageElement Load(string url, loadParam11Delegate1 onLoad = default(loadParam11Delegate1), loadParam21Delegate1 onProgress = default(loadParam21Delegate1), loadParam31Delegate1 onError = default(loadParam31Delegate1));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(object value);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate2(Geometry geometry, Material[] materials);
    [External]
    public delegate void loadParam21Delegate2(object @event);
    [External]
    public delegate void loadParam31Delegate2(object @event);
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
        public extern bool WithCredentials { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern HTMLElement StatusDomElement { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern JSONLoader(LoadingManager manager = default(LoadingManager));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Load(string url, loadParam11Delegate2 onLoad = default(loadParam11Delegate2), loadParam21Delegate2 onProgress = default(loadParam21Delegate2), loadParam31Delegate2 onError = default(loadParam31Delegate2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexturePath(string value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ParseInterface Parse(object json, string texturePath = default(string));
#pragma warning restore CS0626
    }
    [External]
    public delegate void constructorParam01Delegate();
    [External]
    public delegate void constructorParam11Delegate(string url, double loaded, double total);
    [External]
    public delegate void constructorParam21Delegate();
    [External]
    public delegate void onStartDelegate();
    [External]
    public delegate void onLoadDelegate();
    [External]
    public delegate void onProgressDelegate(object item, double loaded, double total);
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
        public extern LoadingManager(constructorParam01Delegate onLoad = default(constructorParam01Delegate), constructorParam11Delegate onProgress = default(constructorParam11Delegate), constructorParam21Delegate onError = default(constructorParam21Delegate));
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
    public delegate void loadParam11Delegate3(BufferGeometry bufferGeometry);
    [External]
    public delegate void loadParam21Delegate3(object @event);
    [External]
    public delegate void loadParam31Delegate3(object @event);
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
        public extern void Load(string url, loadParam11Delegate3 onLoad, loadParam21Delegate3 onProgress = default(loadParam21Delegate3), loadParam31Delegate3 onError = default(loadParam31Delegate3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferGeometry Parse(object json);
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
    public delegate void loadParam11Delegate4(Material material);
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
        public extern void Load(string url, loadParam11Delegate4 onLoad);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture GetTexture(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material Parse(object json);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate5(Object3D @object);
    [External]
    public delegate void parseTParam11Delegate(Object3D @object);
    [External]
    public delegate void parseImagesParam11Delegate();
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
        public extern void Load(string url, loadParam11Delegate5 onLoad = default(loadParam11Delegate5));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexturePath(string value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T Parse<T>(object json, parseTParam11Delegate onLoad = default(parseTParam11Delegate)) where T : Object3D;
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object[] ParseGeometries(object json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Material[] ParseMaterials(object json, Texture[] textures);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AnimationClip[] ParseAnimations(object json);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object[] ParseImages(object json, parseImagesParam11Delegate onLoad);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture[] ParseTextures(object json, object images);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T ParseObject<T>(object data, object[] geometries, Material[] materials) where T : Object3D;
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate6(Texture texture);
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
        public extern Texture Load(string url, loadParam11Delegate6 onLoad = default(loadParam11Delegate6));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate7(CubeTexture texture);
    [External]
    public delegate void loadParam21Delegate4(object @event);
    [External]
    public delegate void loadParam31Delegate4(object @event);
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
        public extern void Load(string[] urls, loadParam11Delegate7 onLoad = default(loadParam11Delegate7), loadParam21Delegate4 onProgress = default(loadParam21Delegate4), loadParam31Delegate4 onError = default(loadParam31Delegate4));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetCrossOrigin(string crossOrigin);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPath(string path);
#pragma warning restore CS0626
    }
    [External]
    public delegate void loadParam11Delegate8(DataTexture dataTexture);
    [External]
    public delegate void loadParam21Delegate5(object @event);
    [External]
    public delegate void loadParam31Delegate5(object @event);
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
        public extern void Load(string url, loadParam11Delegate8 onLoad, loadParam21Delegate5 onProgress = default(loadParam21Delegate5), loadParam31Delegate5 onError = default(loadParam31Delegate5));
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
    public delegate void loadParam11Delegate9(CompressedTexture texture);
    [External]
    public delegate void loadParam21Delegate6(object @event);
    [External]
    public delegate void loadParam31Delegate6(object @event);
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
        public extern void Load(string url, loadParam11Delegate9 onLoad, loadParam21Delegate6 onProgress = default(loadParam21Delegate6), loadParam31Delegate6 onError = default(loadParam31Delegate6));
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
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
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
        double Opacity { get; set; }
        [FieldProperty]
        bool Transparent { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        BlendingDstFactor BlendSrc { get; set; }
        [FieldProperty]
        BlendingSrcFactor BlendDst { get; set; }
        [FieldProperty]
        BlendingEquation BlendEquation { get; set; }
        [FieldProperty]
        double BlendSrcAlpha { get; set; }
        [FieldProperty]
        double BlendDstAlpha { get; set; }
        [FieldProperty]
        double BlendEquationAlpha { get; set; }
        [FieldProperty]
        DepthModes DepthFunc { get; set; }
        [FieldProperty]
        bool DepthTest { get; set; }
        [FieldProperty]
        bool DepthWrite { get; set; }
        [FieldProperty]
        bool ColorWrite { get; set; }
        [FieldProperty]
        double Precision { get; set; }
        [FieldProperty]
        bool PolygonOffset { get; set; }
        [FieldProperty]
        double PolygonOffsetFactor { get; set; }
        [FieldProperty]
        double PolygonOffsetUnits { get; set; }
        [FieldProperty]
        double AlphaTest { get; set; }
        [FieldProperty]
        bool PremultipliedAlpha { get; set; }
        [FieldProperty]
        double Overdraw { get; set; }
        [FieldProperty]
        bool Visible { get; set; }
    }
    [External]
    public delegate void addEventListenerParam11Delegate4(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate4(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate4(Event @event);
    [External]
    public class Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NeedsUpdate { get; set; }
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
        public extern object ToJSON(object meta = default(object));
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
        public extern void AddEventListener(string type, addEventListenerParam11Delegate4 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate4 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate4 listener);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONLineBasicMaterialParameters : LineBasicMaterialParameters
    {
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Linewidth { get; set; }
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
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LineBasicMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        double Linewidth { get; set; }
        [FieldProperty]
        string Linecap { get; set; }
        [FieldProperty]
        string Linejoin { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Linewidth { get; set; }
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
        public extern bool Fog { get; set; }
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
        public extern double Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DashSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface LineDashedMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        double Linewidth { get; set; }
        [FieldProperty]
        double Scale { get; set; }
        [FieldProperty]
        double DashSize { get; set; }
        [FieldProperty]
        double GapSize { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double DashSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double GapSize { get; set; }
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
        public extern bool Fog { get; set; }
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
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AoMapIntensity { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshBasicMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        double Opacity { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        double AoMapIntensity { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        double Reflectivity { get; set; }
        [FieldProperty]
        double RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Skinning { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double AoMapIntensity { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
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
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
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
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshDepthMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
    }
    [External]
    public class MeshDepthMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
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
        public extern double EmissiveIntensity { get; set; }
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
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AoMapIntensity { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
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
        double EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LighhtMap { get; set; }
        [FieldProperty]
        double LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        double AoMapIntensity { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        double Reflectivity { get; set; }
        [FieldProperty]
        double RefractionRatio { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Skinning { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
        [FieldProperty]
        bool MorphNormals { get; set; }
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
        public extern double EmissiveIntensity { get; set; }
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
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AoMapIntensity { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphNormals { get; set; }
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
        public extern double Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Metalness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DisplacementBias { get; set; }
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
        public extern double EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshStandardMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        double Roughness { get; set; }
        [FieldProperty]
        double Metalness { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LighhtMap { get; set; }
        [FieldProperty]
        double LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        double AoMapIntensity { get; set; }
        [FieldProperty]
        Color Emissive { get; set; }
        [FieldProperty]
        double EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture BumpMap { get; set; }
        [FieldProperty]
        double BumpScale { get; set; }
        [FieldProperty]
        Texture NormalMap { get; set; }
        [FieldProperty]
        double NormalScale { get; set; }
        [FieldProperty]
        Texture DisplacementMap { get; set; }
        [FieldProperty]
        double DisplacementScale { get; set; }
        [FieldProperty]
        double DisplacementBias { get; set; }
        [FieldProperty]
        Texture RoughnessMap { get; set; }
        [FieldProperty]
        Texture MetalMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        double EnvMapIntensity { get; set; }
        [FieldProperty]
        double RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Skinning { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
        [FieldProperty]
        bool MorphNormals { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Metalness { get; set; }
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
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double EmissiveIntensity { get; set; }
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
        public extern double BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double DisplacementBias { get; set; }
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
        public extern double EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double RefractionRatio { get; set; }
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
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ClearCoat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ClearCoatRoughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Any<number, string> Color { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Roughness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Metalness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LighhtMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BumpScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture NormalMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double NormalScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture DisplacementMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DisplacementBias { get; set; }
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
        public extern double EnvMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshPhysicalMaterialParameters : MeshStandardMaterialParameters
    {
        [FieldProperty]
        double Reflectivity { get; set; }
        [FieldProperty]
        double ClearCoat { get; set; }
        [FieldProperty]
        double ClearCoatRoughness { get; set; }
    }
    [External]
    public class MeshPhysicalMaterial : MeshStandardMaterial
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ClearCoat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ClearCoatRoughness { get; set; }
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
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshNormalMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
    }
    [External]
    public class MeshNormalMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
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
        public extern double Specular { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Shininess { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Map { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture LightMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double EmissiveIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture EmissiveMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture BumpMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BumpScale { get; set; }
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
        public extern double DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DisplacementBias { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shading Shading { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MeshPhongMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        Any<number, string> Color { get; set; }
        [FieldProperty]
        double Specular { get; set; }
        [FieldProperty]
        double Shininess { get; set; }
        [FieldProperty]
        double Opacity { get; set; }
        [FieldProperty]
        Texture Map { get; set; }
        [FieldProperty]
        Texture LightMap { get; set; }
        [FieldProperty]
        double LightMapIntensity { get; set; }
        [FieldProperty]
        Texture AoMap { get; set; }
        [FieldProperty]
        double AoMapIntensity { get; set; }
        [FieldProperty]
        double Emissive { get; set; }
        [FieldProperty]
        double EmissiveIntensity { get; set; }
        [FieldProperty]
        Texture EmissiveMap { get; set; }
        [FieldProperty]
        Texture BumpMap { get; set; }
        [FieldProperty]
        double BumpScale { get; set; }
        [FieldProperty]
        Texture NormalMap { get; set; }
        [FieldProperty]
        Vector2 NormalScale { get; set; }
        [FieldProperty]
        Texture DisplacementMap { get; set; }
        [FieldProperty]
        double DisplacementScale { get; set; }
        [FieldProperty]
        double DisplacementBias { get; set; }
        [FieldProperty]
        Texture SpecularMap { get; set; }
        [FieldProperty]
        Texture AlphaMap { get; set; }
        [FieldProperty]
        Texture EnvMap { get; set; }
        [FieldProperty]
        Combine Combine { get; set; }
        [FieldProperty]
        double Reflectivity { get; set; }
        [FieldProperty]
        double RefractionRatio { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        string WireframeLinecap { get; set; }
        [FieldProperty]
        string WireframeLinejoin { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Skinning { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
        [FieldProperty]
        bool MorphNormals { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Shininess { get; set; }
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
        public extern double LightMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Texture AoMap { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AoMapIntensity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Color Emissive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double EmissiveIntensity { get; set; }
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
        public extern double BumpScale { get; set; }
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
        public extern double DisplacementScale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double DisplacementBias { get; set; }
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
        public extern double Reflectivity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double RefractionRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
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
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
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
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Metal { get; set; }
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
        public extern object ToJSON(object meta);
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
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool SizeAttenuation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
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
        double Size { get; set; }
        [FieldProperty]
        bool SizeAttenuation { get; set; }
        [FieldProperty]
        Blending Blending { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool SizeAttenuation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Blending Blending { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
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
        public extern object Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Uniforms { get; set; }
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
        public extern double LineWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Lights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ShaderMaterialParameters : MaterialParameters
    {
        [FieldProperty]
        object Defines { get; set; }
        [FieldProperty]
        object Uniforms { get; set; }
        [FieldProperty]
        string VertexShader { get; set; }
        [FieldProperty]
        string FragmentShader { get; set; }
        [FieldProperty]
        Shading Shading { get; set; }
        [FieldProperty]
        double LineWidth { get; set; }
        [FieldProperty]
        bool Wireframe { get; set; }
        [FieldProperty]
        double WireframeLinewidth { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
        [FieldProperty]
        bool Lights { get; set; }
        [FieldProperty]
        Colors VertexColors { get; set; }
        [FieldProperty]
        bool Skinning { get; set; }
        [FieldProperty]
        bool MorphTargets { get; set; }
        [FieldProperty]
        bool MorphNormals { get; set; }
    }
    [ObjectLiteral]
    public class JSONExtensionsInterface : ExtensionsInterface
    {
#pragma warning disable CS0626
        public extern bool Derivatives { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool FragDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DrawBuffers { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ShaderTextureLOD { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ExtensionsInterface
    {
        [FieldProperty]
        bool Derivatives { get; set; }
        [FieldProperty]
        bool FragDepth { get; set; }
        [FieldProperty]
        bool DrawBuffers { get; set; }
        [FieldProperty]
        bool ShaderTextureLOD { get; set; }
    }
    [External]
    public class ShaderMaterial : Material
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Defines { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Uniforms { get; set; }
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
        public extern double Linewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Wireframe { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double WireframeLinewidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Lights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Colors VertexColors { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Skinning { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool MorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Derivatives { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ExtensionsInterface Extensions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object DefaultAttributeValues { get; set; }
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
        public extern object ToJSON(object meta);
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
        public extern double Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Fog { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string Name { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Side Side { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Transparent { get; set; }
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
        public extern double BlendSrcAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendDstAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BlendEquationAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern DepthModes DepthFunc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ColorWrite { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PolygonOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PolygonOffsetUnits { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double AlphaTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Overdraw { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Visible { get; set; }
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
        double Rotation { get; set; }
        [FieldProperty]
        bool Fog { get; set; }
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
        public extern double Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Fog { get; set; }
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
        public extern object Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IsEmpty();
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
        public extern Box2 ExpandByScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsPoint(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsBox(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 GetParameter(Vector2 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 ClampPoint(Vector2 point, Vector2 optionalTarget = default(Vector2));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToPoint(Vector2 point);
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
        public extern bool Equals(Box2 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionBox(object b);
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
        public extern Box3 SetFromArray(double[] array);
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
        public extern bool IsEmpty();
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
        public extern Box3 ExpandByScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 GetParameter(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToPoint(Vector3 point);
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
        public extern bool Equals(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionBox(object b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionSphere(object s);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONHSL : HSL
    {
#pragma warning disable CS0626
        public extern double H { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double S { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double L { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface HSL
    {
        [FieldProperty]
        double H { get; set; }
        [FieldProperty]
        double S { get; set; }
        [FieldProperty]
        double L { get; set; }
    }
    [External]
    public class Color
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double R { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double G { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double B { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Color(Color color = default(Color));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(string color = default(string));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(double color = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern Color(double r, double g, double b);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Color Set(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Set(double color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Set(string color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetHex(double hex);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetRGB(double r, double g, double b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color SetHSL(double h, double s, double l);
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
        public extern Color CopyGammaToLinear(Color color, double gammaFactor = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color CopyLinearToGamma(Color color, double gammaFactor = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color ConvertGammaToLinear();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color ConvertLinearToGamma();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetHex();
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
        public extern Color OffsetHSL(double h, double s, double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Add(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color AddColors(Color color1, Color color2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color AddScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Multiply(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color Lerp(Color color, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Color color);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color FromArray(double[] rgb, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] array = default(double[]), double offset = default(double));
#pragma warning restore CS0626
    }
    [External]
    public class Euler
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Order { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate OnChangeCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static string[] RotationOrders { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static string DefaultOrder { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Euler(double x = default(double), double y = default(double), double z = default(double), string order = default(string));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Euler Set(double x, double y, double z, string order = default(string));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Copy(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromRotationMatrix(Matrix4 m, string order = default(string), bool update = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromQuaternion(Quaternion q, string order = default(string), bool update = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler SetFromVector3(Vector3 v, string order = default(string));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler Reorder(string newOrder);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Euler FromArray(object[] xyzo);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] array = default(double[]), double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ToVector3(Vector3 optionalResult = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnChange(Delegate callback);
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
        public extern Frustum Set(double p0 = default(double), double p1 = default(double), double p2 = default(double), double p3 = default(double), double p4 = default(double), double p5 = default(double));
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
        public extern bool IntersectsObject(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsPoint(Vector3 point);
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
        public extern double DistanceSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Distance();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 At(double t, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ClosestPointToPointParameter(Vector3 point, bool clampToLine = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClosestPointToPoint(Vector3 point, bool clampToLine = default(bool), Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Line3 ApplyMatrix4(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Line3 line);
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
        public delegate Matrix multiplyScalarDelegate(double s);

#pragma warning disable CS0626
        public extern Matrix MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern multiplyScalarDelegate multiplyScalar { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate double determinantDelegate();

#pragma warning disable CS0626
        public extern double Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern determinantDelegate determinant { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Matrix getInverseDelegate(Matrix matrix, bool throwOnInvertible = default(bool));

#pragma warning disable CS0626
        public extern Matrix GetInverse(Matrix matrix, bool throwOnInvertible = default(bool));
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
        Matrix MultiplyScalar(double s);
        double Determinant();
        Matrix GetInverse(Matrix matrix, bool throwOnInvertible = default(bool));
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
        public extern Matrix3 Set(double n11, double n12, double n13, double n21, double n22, double n23, double n31, double n32, double n33);
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
        public extern object MultiplyVector3Array(object a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ApplyToVector3Array(double[] array, double offset = default(double), double length = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute ApplyToBuffer(BufferAttribute buffer, double offset = default(double), double length = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetInverse(Matrix3 matrix, bool throwOnDegenerate = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetInverse(Matrix4 matrix, bool throwOnDegenerate = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] FlattenToArrayOffset(double[] array, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 GetNormalMatrix(Matrix4 matrix4);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] TransposeIntoArray(double[] r);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix3 FromArray(double[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object MultiplyVector3(Vector3 vector);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Copy(Matrix m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.GetInverse(Matrix matrix, bool throwOnInvertible);
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
        public extern Matrix4 Set(double n11, double n12, double n13, double n14, double n21, double n22, double n23, double n24, double n31, double n32, double n33, double n34, double n41, double n42, double n43, double n44);
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
        public extern Matrix4 MultiplyToArray(Matrix4 a, Matrix4 b, double[] r);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] MultiplyVector3Array(double[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ApplyToVector3Array(double[] array, double offset = default(double), double length = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern BufferAttribute ApplyToBuffer(BufferAttribute buffer, double offset = default(double), double length = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Determinant();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Transpose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] FlattenToArrayOffset(double[] array, double offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 SetPosition(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 GetInverse(Matrix4 m, bool throwOnDegeneratee = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Scale(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetMaxScaleOnAxis();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeTranslation(double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationX(double theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationY(double theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationZ(double theta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeRotationAxis(Vector3 axis, double angle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeScale(double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 Compose(Vector3 translation, Quaternion rotation, Vector3 scale);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object[] Decompose(Vector3 translation = default(Vector3), Quaternion rotation = default(Quaternion), Vector3 scale = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeFrustum(double left, double right, double bottom, double top, double near, double far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakePerspective(double fov, double aspect, double near, double far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 MakeOrthographic(double left, double right, double top, double bottom, double near, double far);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Matrix4 FromArray(double[] array);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetPosition();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object MultiplyVector3(object v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object MultiplyVector4(object v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RotateAxis(object v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void CrossVector(object v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Identity();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.Copy(Matrix m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Matrix Matrix.GetInverse(Matrix matrix, bool throwOnInvertible);
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
        public extern double Constant { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Plane(Vector3 normal = default(Vector3), double constant = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Plane Set(Vector3 normal, double constant);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane SetComponents(double x, double y, double z, double w);
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
        public extern double DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToSphere(Sphere sphere);
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
        public extern bool IntersectsLine(Line3 line);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 CoplanarPoint(bool optionalTarget = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane ApplyMatrix4(Matrix4 matrix, Matrix3 optionalNormalMatrix = default(Matrix3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Plane Translate(Vector3 offset);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionLine(object l);
#pragma warning restore CS0626
    }
    [External]
    public class Spherical
    {
#pragma warning disable CS0824
        public extern Spherical(double radius = default(double), double phi = default(double), double theta = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Set(double radius, double phi, double theta);
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
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double W { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate OnChangeCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Quaternion(double x = default(double), double y = default(double), double z = default(double), double w = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Quaternion Set(double x, double y, double z, double w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Copy(Quaternion q);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromEuler(Euler euler, bool update = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion SetFromAxisAngle(Vector3 axis, double angle);
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
        public extern double Dot(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Length();
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
        public extern object MultiplyVector3(object v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion Slerp(Quaternion qb, double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Quaternion v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion FromArray(double[] n);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion FromArray(double[] xyzw, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] xyzw = default(double[]), double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Quaternion OnChange(Delegate callback);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Quaternion Slerp(Quaternion qa, Quaternion qb, Quaternion qm, double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Quaternion SlerpFlat(double[] dst, double dstOffset, double[] src0, double srcOffset, double[] src1, double stcOffset1, double t);
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
        public extern Vector3 At(double t, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 LookAt(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray Recast(double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClosestPointToPoint(Vector3 point, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceSqToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceSqToSegment(Vector3 v0, Vector3 v1, Vector3 optionalPointOnRay = default(Vector3), Vector3 optionalPointOnSegment = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectSphere(Sphere sphere, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectPlane(Plane plane, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsPlane(Plane plane);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectBox(Box3 box, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 IntersectTriangle(Vector3 a, Vector3 b, Vector3 c, bool backfaceCulling, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Ray ApplyMatrix4(Matrix4 matrix4);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Ray ray);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionSphere(object s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionPlane(object p);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object IsIntersectionBox(object b);
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
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Sphere(Vector3 center = default(Vector3), double radius = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Sphere Set(Vector3 center, double radius);
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
        public extern bool Empty();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsSphere(Sphere sphere);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsBox(Box3 box);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool IntersectsPlane(Plane plane);
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
        public extern bool Equals(Sphere sphere);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONSplineControlPoint : SplineControlPoint
    {
#pragma warning disable CS0626
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Z { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface SplineControlPoint
    {
        [FieldProperty]
        double X { get; set; }
        [FieldProperty]
        double Y { get; set; }
        [FieldProperty]
        double Z { get; set; }
    }
    [ObjectLiteral]
    public class JSONGetLengthInterface : GetLengthInterface
    {
#pragma warning disable CS0626
        public extern double[] Chunks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Total { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GetLengthInterface
    {
        [FieldProperty]
        double[] Chunks { get; set; }
        [FieldProperty]
        double Total { get; set; }
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
        public extern void InitFromArray(double[][] a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern SplineControlPoint GetPoint(double k);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[][] GetControlPointsArray();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern GetLengthInterface GetLength(double nSubDivisions = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ReparametrizeByArcLength(double samplingCoef);
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
        public extern Triangle SetFromPointsAndIndices(Vector3[] points, double i0, double i1, double i2);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Triangle Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Triangle Copy(Triangle triangle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Area();
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
        public extern bool ContainsPoint(Vector3 point);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Triangle triangle);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector3 Normal(Vector3 a, Vector3 b, Vector3 c, Vector3 optionalTarget = default(Vector3));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Vector3 BarycoordFromPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c, Vector3 optionalTarget);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static bool ContainsPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONVector : Vector
    {
        [External]
        public delegate void setComponentDelegate(double index, double value);

#pragma warning disable CS0626
        public extern void SetComponent(double index, double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern setComponentDelegate setComponent { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate double getComponentDelegate(double index);

#pragma warning disable CS0626
        public extern double GetComponent(double index);
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
        public delegate Vector multiplyScalarDelegate(double s);

#pragma warning disable CS0626
        public extern Vector MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern multiplyScalarDelegate multiplyScalar { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector divideScalarDelegate(double s);

#pragma warning disable CS0626
        public extern Vector DivideScalar(double s);
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
        public delegate double dotDelegate(Vector v);

#pragma warning disable CS0626
        public extern double Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern dotDelegate dot { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate double lengthSqDelegate();

#pragma warning disable CS0626
        public extern double LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern lengthSqDelegate lengthSq { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate double lengthDelegate();

#pragma warning disable CS0626
        public extern double Length();
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
        public delegate double distanceToDelegate(Vector v);

#pragma warning disable CS0626
        public extern double DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern distanceToDelegate distanceTo { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate double distanceToSquaredDelegate(Vector v);

#pragma warning disable CS0626
        public extern double DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern distanceToSquaredDelegate distanceToSquared { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector setLengthDelegate(double l);

#pragma warning disable CS0626
        public extern Vector SetLength(double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern setLengthDelegate setLength { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector lerpDelegate(Vector v, double alpha);

#pragma warning disable CS0626
        public extern Vector Lerp(Vector v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern lerpDelegate lerp { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate bool equalsDelegate(Vector v);

#pragma warning disable CS0626
        public extern bool Equals(Vector v);
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
        void SetComponent(double index, double value);
        double GetComponent(double index);
        Vector Copy(Vector v);
        Vector Add(Vector v);
        Vector AddVectors(Vector a, Vector b);
        Vector Sub(Vector v);
        Vector SubVectors(Vector a, Vector b);
        Vector MultiplyScalar(double s);
        Vector DivideScalar(double s);
        Vector Negate();
        double Dot(Vector v);
        double LengthSq();
        double Length();
        Vector Normalize();
        double DistanceTo(Vector v);
        double DistanceToSquared(Vector v);
        Vector SetLength(double l);
        Vector Lerp(Vector v, double alpha);
        bool Equals(Vector v);
        Vector Clone();
    }
    [External]
    public class Vector2 : Vector
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector2(double x = default(double), double y = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector2 Set(double x, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetX(double x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetY(double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(double index, double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetComponent(double index);
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
        public extern Vector2 AddScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 AddVectors(Vector2 a, Vector2 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 AddScaledVector(Vector2 v, double s);
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
        public extern Vector2 MultiplyScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Divide(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 DivideScalar(double s);
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
        public extern Vector2 ClampScalar(double min, double max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 ClampLength(double min, double max);
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
        public extern double Dot(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Angle();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceTo(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToSquared(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 SetLength(double length);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 Lerp(Vector2 v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 LerpVectors(Vector2 v1, Vector2 v2, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Vector2 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 FromArray(double[] xy, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] xy = default(double[]), double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 FromAttribute(BufferAttribute attribute, double index, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2 RotateAround(Vector2 center, double angle);
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
        extern Vector Vector.MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern bool Vector.Equals(Vector v);
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
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector3(double x = default(double), double y = default(double), double z = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector3 Set(double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetX(double x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetY(double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetZ(double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(double index, double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetComponent(double index);
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
        public extern Vector3 AddScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 AddScaledVector(Vector3 v, double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 AddVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Sub(Vector3 a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SubScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SubVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Multiply(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 MultiplyVectors(Vector3 a, Vector3 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyEuler(Euler euler);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ApplyAxisAngle(Vector3 axis, double angle);
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
        public extern Vector3 DivideScalar(double s);
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
        public extern Vector3 ClampScalar(double min, double max);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 ClampLength(double min, double max);
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
        public extern double Dot(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetLength(double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 Lerp(Vector3 v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 LerpVectors(Vector3 v1, Vector3 v2, double alpha);
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
        public extern double AngleTo(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceTo(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToSquared(Vector3 v);
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
        public extern Vector3 GetColumnFromMatrixColumn(double index, Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixColumn(Matrix4 matrix, double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 SetFromMatrixColumn(double index, Matrix4 matrix);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Vector3 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 FromArray(double[] xyz, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] xyz = default(double[]), double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector3 FromAttribute(BufferAttribute attribute, double index, double offset = default(double));
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
        extern Vector Vector.MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern bool Vector.Equals(Vector v);
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
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double W { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Vector4(double x = default(double), double y = default(double), double z = default(double), double w = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Vector4 Set(double x, double y, double z, double w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetScalar(double scalar);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetX(double x);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetY(double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetZ(double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetW(double w);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetComponent(double index, double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetComponent(double index);
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
        public extern Vector4 AddScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 AddVectors(Vector4 a, Vector4 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 AddScaledVector(Vector4 v, double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Sub(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SubScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SubVectors(Vector4 a, Vector4 b);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 ApplyMatrix4(Matrix4 m);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 DivideScalar(double s);
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
        public extern Vector4 ClampScalar(double min, double max);
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
        public extern double Dot(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthSq();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Length();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LengthManhattan();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 SetLength(double length);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 Lerp(Vector4 v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 LerpVectors(Vector4 v1, Vector4 v2, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Equals(Vector4 v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 FromArray(double[] xyzw, double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] ToArray(double[] xyzw = default(double[]), double offset = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector4 FromAttribute(BufferAttribute attribute, double index, double offset = default(double));
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
        extern Vector Vector.MultiplyScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.DivideScalar(double s);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Negate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern double Vector.Dot(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Normalize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceTo(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DistanceToSquared(Vector v);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.SetLength(double l);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern Vector Vector.Lerp(Vector v, double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        extern bool Vector.Equals(Vector v);
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
        public extern object ParameterPositions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object SamplesValues { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ValueSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object ResultBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Interpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Evaluate(double time);
#pragma warning restore CS0626
    }
    [External]
    public class CubicInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern CubicInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Interpolate_(double i1, double t0, double t, double t1);
#pragma warning restore CS0626
    }
    [External]
    public class DiscreteInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern DiscreteInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Interpolate_(double i1, double t0, double t, double t1);
#pragma warning restore CS0626
    }
    [External]
    public class LinearInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern LinearInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Interpolate_(double i1, double t0, double t, double t1);
#pragma warning restore CS0626
    }
    [External]
    public class QuaternionLinearInterpolant : Interpolant
    {
#pragma warning disable CS0824
        public extern QuaternionLinearInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Interpolate_(double i1, double t0, double t, double t1);
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
        public extern object[] Levels { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object[] Objects { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LOD();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddLevel(Object3D @object, double distance = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Object3D GetObjectForDistance(double distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, object intersects);
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
        public extern object ToJSON(object meta);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONLensFlareProperty : LensFlareProperty
    {
#pragma warning disable CS0626
        public extern Texture Texture { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Distance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double X { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Y { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Z { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Scale { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Rotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Opacity { get; set; }
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
        double Size { get; set; }
        [FieldProperty]
        double Distance { get; set; }
        [FieldProperty]
        double X { get; set; }
        [FieldProperty]
        double Y { get; set; }
        [FieldProperty]
        double Z { get; set; }
        [FieldProperty]
        double Scale { get; set; }
        [FieldProperty]
        double Rotation { get; set; }
        [FieldProperty]
        double Opacity { get; set; }
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
        public extern LensFlare(Texture texture = default(Texture), double size = default(double), double distance = default(double), Blending blending = default(Blending), Color color = default(Color));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Add(Texture texture, double size = default(double), double distance = default(double), Blending blending = default(Blending), Color color = default(Color));
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
        public extern Line(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial> material = default(Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial>), double mode = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, object intersects);
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
        public extern LineSegments(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial> material = default(Any<LineDashedMaterial, LineBasicMaterial, ShaderMaterial>), double mode = default(double));
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
        public extern double GetMorphTargetIndexByName(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Raycast(Raycaster raycaster, object intersects);
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
        public extern void Raycast(Raycaster raycaster, object intersects);
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
        public extern bool UseVertexTexture { get; set; }
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
        public extern double BoneTextureWidth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double BoneTextureHeight { get; set; }
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
        public extern Skeleton(Bone[] bones, Matrix4[] boneInverses = default(Matrix4[]), bool useVertexTexture = default(bool));
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
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshBasicMaterial material = default(MeshBasicMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshDepthMaterial material = default(MeshDepthMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MultiMaterial material = default(MultiMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshLambertMaterial material = default(MeshLambertMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshNormalMaterial material = default(MeshNormalMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), MeshPhongMaterial material = default(MeshPhongMaterial), bool useVertexTexture = default(bool));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern SkinnedMesh(Any<Geometry, BufferGeometry> geometry = default(Any<Geometry, BufferGeometry>), ShaderMaterial material = default(ShaderMaterial), bool useVertexTexture = default(bool));
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
        public extern void UpdateMatrixWorld(bool force = default(bool));
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
        public extern void Raycast(Raycaster raycaster, object intersects);
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
        public delegate void setSizeDelegate(double width, double height, bool updateStyle = default(bool));

#pragma warning disable CS0626
        public extern void SetSize(double width, double height, bool updateStyle = default(bool));
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
        void SetSize(double width, double height, bool updateStyle = default(bool));
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
        public extern bool Alpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PremultipliedAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Antialias { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Stencil { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool PreserveDrawingBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ClearColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ClearAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DevicePixelRatio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool LogarithmicDepthBuffer { get; set; }
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
        bool Alpha { get; set; }
        [FieldProperty]
        bool PremultipliedAlpha { get; set; }
        [FieldProperty]
        bool Antialias { get; set; }
        [FieldProperty]
        bool Stencil { get; set; }
        [FieldProperty]
        bool PreserveDrawingBuffer { get; set; }
        [FieldProperty]
        double ClearColor { get; set; }
        [FieldProperty]
        double ClearAlpha { get; set; }
        [FieldProperty]
        double DevicePixelRatio { get; set; }
        [FieldProperty]
        bool LogarithmicDepthBuffer { get; set; }
    }
    [ObjectLiteral]
    public class JSONMemoryInterface : MemoryInterface
    {
#pragma warning disable CS0626
        public extern double Geometries { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Textures { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MemoryInterface
    {
        [FieldProperty]
        double Geometries { get; set; }
        [FieldProperty]
        double Textures { get; set; }
    }
    [ObjectLiteral]
    public class JSONRenderInterface : RenderInterface
    {
#pragma warning disable CS0626
        public extern double Calls { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Vertices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Faces { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Points { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface RenderInterface
    {
        [FieldProperty]
        double Calls { get; set; }
        [FieldProperty]
        double Vertices { get; set; }
        [FieldProperty]
        double Faces { get; set; }
        [FieldProperty]
        double Points { get; set; }
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
        public extern double Programs { get; set; }
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
        double Programs { get; set; }
    }
    [ObjectLiteral]
    public class JSONGetSizeInterface : GetSizeInterface
    {
#pragma warning disable CS0626
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface GetSizeInterface
    {
        [FieldProperty]
        double Width { get; set; }
        [FieldProperty]
        double Height { get; set; }
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
        public extern bool AutoClear { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AutoClearColor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AutoClearDepth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AutoClearStencil { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool SortObjects { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern WebGLExtensions Extensions { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double GammaFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool GammaInput { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool GammaOutput { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool PhysicallyCorrectLights { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern ToneMapping ToneMapping { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ToneMappingExposure { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ToneMappingWhitePoint { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ShadowMapDebug { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double MaxMorphTargets { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double MaxMorphNormals { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AutoScaleCubemaps { get; set; }
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
        public extern bool ShadowMapEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern CullFace ShadowMapCullFace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double PixelRation { get; set; }
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
        public extern object GetContextAttributes();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ForceContextLoss();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetMaxAnisotropy();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetPrecision();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetPixelRatio();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPixelRatio(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern GetSizeInterface GetSize();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetSize(double width, double height, bool updateStyle = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetViewport(double x = default(double), double y = default(double), double width = default(double), double height = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissor(double x, double y, double width, double height);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissorTest(bool enable);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Color GetClearColor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(Color color, double alpha = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(string color, double alpha = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearColor(double color, double alpha = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetClearAlpha();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetClearAlpha(double alpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Clear(bool color = default(bool), bool depth = default(bool), bool stencil = default(bool));
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
        public extern void ClearTarget(WebGLRenderTarget renderTarget, bool color, bool depth, bool stencil);
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
        public extern void RenderBufferDirect(Camera camera, Fog fog, Material material, object geometryGroup, Object3D @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, RenderTarget renderTarget = default(RenderTarget), bool forceClear = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFaceCulling(CullFace cullFace = default(CullFace), FrontFaceDirection frontFace = default(FrontFaceDirection));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetTexture(Texture texture, double slot);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern RenderTarget GetCurrentRenderTarget();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRenderTarget(RenderTarget renderTarget);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ReadRenderTargetPixels(RenderTarget renderTarget, double x, double y, double width, double height, object buffer);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsFloatTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsHalfFloatTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsStandardDerivatives();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsCompressedTextureS3TC();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsCompressedTexturePVRTC();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsBlendMinMax();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsVertexTextures();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object SupportsInstancedArrays();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object EnableScissorTest(object boolean);
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
        public extern double Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern TextureDataType Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Anisotropy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool StencilBuffer { get; set; }
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
        double Format { get; set; }
        [FieldProperty]
        TextureDataType Type { get; set; }
        [FieldProperty]
        double Anisotropy { get; set; }
        [FieldProperty]
        bool DepthBuffer { get; set; }
        [FieldProperty]
        bool StencilBuffer { get; set; }
    }
    [External]
    public delegate void addEventListenerParam11Delegate5(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate5(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate5(Event @event);
    [External]
    public class WebGLRenderTarget : RenderTarget
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Uuid { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Vector4 Scissor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool ScissorTest { get; set; }
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
        public extern bool DepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool StencilBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object WrapS { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object WrapT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MagFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MinFilter { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Anisotropy { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Offset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Repeat { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Format { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object GenerateMipmaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLRenderTarget(double width, double height, WebGLRenderTargetOptions options = default(WebGLRenderTargetOptions));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetSize(double width, double height);
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
        public extern void AddEventListener(string type, addEventListenerParam11Delegate5 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate5 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate5 listener);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLRenderTargetCube : WebGLRenderTarget
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ActiveCubeFace { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ActiveMipMapLevel { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLRenderTargetCube(double width, double height, WebGLRenderTargetOptions options = default(WebGLRenderTargetOptions));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONAderChunkInterface : AderChunkInterface
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
        public delegate string AderChunkInterfaceIndexerDelegate(string name);

#pragma warning disable CS0626
        public extern string this[string name] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AderChunkInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface AderChunkInterface
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
        public extern object Uniforms { get; set; }
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
        object Uniforms { get; set; }
        [FieldProperty]
        string VertexShader { get; set; }
        [FieldProperty]
        string FragmentShader { get; set; }
    }
    [ObjectLiteral]
    public class JSONAderLibInterface : AderLibInterface
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
        public delegate Shader AderLibInterfaceIndexerDelegate(string name);

#pragma warning disable CS0626
        public extern Shader this[string name] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern AderLibInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface AderLibInterface
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
        public extern object Value { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface IUniform
    {
        [FieldProperty]
        string Type { get; set; }
        [FieldProperty]
        object Value { get; set; }
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
        public extern object[] Value { get; set; }
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
        object[] Value { get; set; }
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
        public extern object[] Value { get; set; }
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
        object[] Value { get; set; }
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
        public extern object[] Value { get; set; }
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
        object[] Value { get; set; }
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
        public extern object[] Value { get; set; }
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
        object[] Value { get; set; }
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
    public class JSONIformsLibInterface : IformsLibInterface
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
    public interface IformsLibInterface
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
        public extern bool Dynamic { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate OnUpdateCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Uniform(string type, string value);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Uniform OnUpdate(Delegate callback);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLBufferRenderer
    {
#pragma warning disable CS0824
        public extern WebGLBufferRenderer(WebGLRenderingContext _gl, object extensions, object _infoRender);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetMode(object value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(object start, object count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderInstances(object geometry);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONWebGLCapabilitiesParameters : WebGLCapabilitiesParameters
    {
#pragma warning disable CS0626
        public extern object Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object LogarithmicDepthBuffer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WebGLCapabilitiesParameters
    {
        [FieldProperty]
        object Precision { get; set; }
        [FieldProperty]
        object LogarithmicDepthBuffer { get; set; }
    }
    [External]
    public class WebGLCapabilities
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Precision { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object LogarithmicDepthBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxVertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxTextureSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxCubemapSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxAttributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxVertexUniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxVaryings { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object MaxFragmentUniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object VertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object FloatFragmentTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object FloatVertexTextures { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLCapabilities(WebGLRenderingContext gl, object extensions, WebGLCapabilitiesParameters parameters);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object GetMaxPrecision(object precision);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLExtensions
    {
#pragma warning disable CS0824
        public extern WebGLExtensions(WebGLRenderingContext gl);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Get(string name);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLGeometries
    {
#pragma warning disable CS0824
        public extern WebGLGeometries(WebGLRenderingContext gl, object extensions, object _infoRender);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Get(object @object);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLLights
    {
#pragma warning disable CS0824
        public extern WebGLLights(WebGLRenderingContext gl, object properties, object info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object Get(object light);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLIndexedBufferRenderer
    {
#pragma warning disable CS0824
        public extern WebGLIndexedBufferRenderer(WebGLRenderingContext gl, object properties, object info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetMode(object value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetIndex(object index);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Render(object start, double count);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RenderInstances(object geometry, object start, double count);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLObjects
    {
#pragma warning disable CS0824
        public extern WebGLObjects(WebGLRenderingContext gl, object properties, object info);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object GetAttributeBuffer(object attribute);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetWireframeAttribute(object geometry);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update(object @object);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLProgram
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string Code { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double UsedTimes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Program { get; set; }
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
        public extern object Uniforms { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Attributes { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLProgram(WebGLRenderer renderer, string code, ShaderMaterial material, WebGLRendererParameters parameters);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object GetUniforms();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetAttributes();
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
        public extern object[] Programs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern WebGLPrograms(WebGLRenderer renderer, object capabilities);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern object[] GetParameters(ShaderMaterial material, object lights, object fog, object @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern string GetProgramCode(ShaderMaterial material, object parameters);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern WebGLProgram AcquireProgram(ShaderMaterial material, object parameters, string code);
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
        public extern object Get(object @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Delete(object @object);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Clear();
#pragma warning restore CS0626
    }
    [External]
    public class WebGLShader
    {
#pragma warning disable CS0824
        public extern WebGLShader(object gl, string type, string @string);
#pragma warning restore CS0824
    }
    [External]
    public class WebGLShadowMap
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Enabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NeedsUpdate { get; set; }
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
        public extern WebGLShadowMap(Renderer _renderer, object[] _lights, object[] _objects);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera);
#pragma warning restore CS0626
    }
    [External]
    public class WebGLState
    {
#pragma warning disable CS0824
        public extern WebGLState(object gl, object extensions, Delegate paramThreeToGL);
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
        public extern void EnableAttributeAndDivisor(string attribute, object meshPerAttribute, object extension);
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
        public extern object[] GetCompressedTextureFormats();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetBlending(double blending, double blendEquation, double blendSrc, double blendDst, double blendEquationAlpha, double blendSrcAlpha, double blendDstAlpha);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthFunc(Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthTest(double depthTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDepthWrite(double depthWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetColorWrite(double colorWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilFunc(Delegate stencilFunc, object stencilRef, object stencilMask);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilOp(object stencilFail, object stencilZFail, object stencilZPass);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilTest(bool stencilTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetStencilWrite(object stencilWrite);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetFlipSided(double flipSided);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLineWidth(double width);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPolygonOffset(double polygonoffset, double factor, double units);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetScissorTest(bool scissorTest);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool GetScissorTest();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ActiveTexture(object webglSlot);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void BindTexture(object webglType, object webglTexture);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void CompressedTexImage2D();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TexImage2D();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearColor(double r, double g, double b, double a);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearDepth(double depth);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClearStencil(object stencil);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Scissor(object scissor);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Viewport(object viewport);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Reset();
#pragma warning restore CS0626
    }
    [External]
    public class LensFlarePlugin
    {
#pragma warning disable CS0824
        public extern LensFlarePlugin(WebGLRenderer renderer, object[] flares);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, double viewportWidth, double viewportHeight);
#pragma warning restore CS0626
    }
    [External]
    public class SpritePlugin
    {
#pragma warning disable CS0824
        public extern SpritePlugin(WebGLRenderer renderer, object[] sprites);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Render(Scene scene, Camera camera, double viewportWidth, double viewportHeight);
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
        public extern bool AutoUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Scene();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Scene Copy(Scene source, bool recursive = default(bool));
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
        public extern double Near { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Far { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Fog(double hex, double near = default(double), double far = default(double));
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
        public extern double Density { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern FogExp2(Any<number, string> hex, double density = default(double));
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
    public delegate void addEventListenerParam11Delegate6(Event @event);
    [External]
    public delegate void hasEventListenerParam11Delegate6(Event @event);
    [External]
    public delegate void removeEventListenerParam11Delegate6(Event @event);
    [External]
    public class Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Id { get; set; }
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
        public extern object Image { get; set; }
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
        public extern double Anisotropy { get; set; }
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
        public extern bool GenerateMipmaps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool PremultiplyAlpha { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool FlipY { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double UnpackAlignment { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern TextureEncoding Encoding { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double Version { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool NeedsUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern onUpdateDelegate OnUpdate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static object DEFAULT_IMAGE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern static object DEFAULT_MAPPING { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern Texture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> image, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), double anisotropy = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern Texture Clone();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Texture Copy(Texture source);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object ToJSON(object meta);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Dispose();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void TransformUv(Vector uv);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddEventListener(string type, addEventListenerParam11Delegate6 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void HasEventListener(string type, hasEventListenerParam11Delegate6 listener);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void RemoveEventListener(string type, removeEventListenerParam11Delegate6 listener);
#pragma warning restore CS0626
    }
    [External]
    public class CanvasTexture : Texture
    {
#pragma warning disable CS0824
        public extern CanvasTexture(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> canvas, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), double anisotropy = default(double));
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
        public extern object Images { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CubeTexture(object[] images = default(object[]), Mapping apping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), double anisotropy = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern CubeTexture Copy(CubeTexture source);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONImageInterface : ImageInterface
    {
#pragma warning disable CS0626
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ImageInterface
    {
        [FieldProperty]
        double Width { get; set; }
        [FieldProperty]
        double Height { get; set; }
    }
    [External]
    public class CompressedTexture : Texture
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ImageInterface Image { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CompressedTexture(ImageData[] mipmaps, double width, double height, PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), double anisotropy = default(double));
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
        public extern DataTexture(Any<Any<ArrayBuffer, Int8Array, Uint8Array>, Uint8ClampedArray, Int16Array, Uint16Array, Int32Array, Uint32Array, Float32Array, Float64Array> data, double width, double height, PixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, double anisotropy = default(double));
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
        public extern VideoTexture(HTMLVideoElement video, Mapping mapping = default(Mapping), Wrapping wrapS = default(Wrapping), Wrapping wrapT = default(Wrapping), TextureFilter magFilter = default(TextureFilter), TextureFilter minFilter = default(TextureFilter), PixelFormat format = default(PixelFormat), TextureDataType type = default(TextureDataType), double anisotropy = default(double));
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
        public extern bool Autoplay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double StartTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double PlaybackRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool HasPlaybackControl { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool IsPlaying { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern string SourceType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Filter { get; set; }
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
        public extern void SetFilter(object value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetFilter();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetPlaybackRate(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetPlaybackRate();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnEnded();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLoop(bool value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool GetLoop();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetVolume(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetVolume();
#pragma warning restore CS0626
    }
    [External]
    public class AudioAnalyser
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern object Analyser { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Uint8Array Data { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AudioAnalyser(object audio, double fftSize);
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
        public extern object Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool Ready { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern Delegate[] ReadyCallbacks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern AudioBuffer(object context);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern AudioBuffer Load(string file);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void OnReady(Delegate callback);
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
        public extern void SetRefDistance(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetRefDistance();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetRolloffFactor(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetRolloffFactor();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetDistanceModel(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetDistanceModel();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetMaxDistance(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetMaxDistance();
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
        public extern void SetFilter(object value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern object GetFilter();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetMasterVolume(double value);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetMasterVolume();
#pragma warning restore CS0626
    }
    [External]
    public class Curve<T> where T : Vector
    {
#pragma warning disable CS0626
        public extern T GetPoint(double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetPointAt(double u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T[] GetPoints(double divisions = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T[] GetSpacedPoints(double divisions = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetLength();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] GetLengths(double divisions = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void UpdateArcLengths();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetUtoTmapping(double u, double distance);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetTangent(double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetTangentAt(double u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static Delegate Create(Delegate constructorFunc, Delegate getPointFunc);
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
        public extern bool AutoClose { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CurvePath();
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Add(Curve<T> curve);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool CheckConnection();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void ClosePath();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern T GetPoint(double t);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetLength();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double[] GetCurveLengths();
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry CreatePointsGeometry(double divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Geometry CreateSpacedPointsGeometry(double divisions);
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
        public extern object Args { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PathAction
    {
        [FieldProperty]
        PathActions Action { get; set; }
        [FieldProperty]
        object Args { get; set; }
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
        public extern void MoveTo(double x, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void LineTo(double x, double y);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void QuadraticCurveTo(double aCPx, double aCPy, double aX, double aY);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void BezierCurveTo(double aCP1x, double aCP1y, double aCP2x, double aCP2y, double aX, double aY);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SplineThru(Vector2[] pts);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Arc(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Absarc(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Ellipse(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Absellipse(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] GetSpacedPoints(double divisions = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] GetPoints(double divisions = default(double), bool closedPath = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Shape[] ToShapes(bool isCCW, object noHoles);
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
        public extern ExtrudeGeometry Extrude(object options = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ShapeGeometry MakeGeometry(object options = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[][] GetPointsHoles(double divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern ExtractAllPointsInterface ExtractAllPoints(double divisions);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern Vector2[] ExtractPoints(double divisions);
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
        public extern Vector3 GetPoint(double t);
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
        public extern Vector3 GetPoint(double t);
#pragma warning restore CS0626
    }
    [External]
    public class EllipseCurve : Curve<Vector2>
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AX { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AY { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double XRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double YRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AStartAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double AEndAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern bool AClockwise { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        [FieldProperty]
        public extern double ARotation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern EllipseCurve(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation);
#pragma warning restore CS0824
    }
    [External]
    public class ArcCurve : EllipseCurve
    {
#pragma warning disable CS0824
        public extern ArcCurve(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise);
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
        public extern Vector3 GetPoint(double t);
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
        public extern Vector3 GetPoint(double t);
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
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Depth { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double DepthSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface
    {
        [FieldProperty]
        double Width { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double Depth { get; set; }
        [FieldProperty]
        double WidthSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
        [FieldProperty]
        double DepthSegments { get; set; }
    }
    [External]
    public class BoxBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern BoxBufferGeometry(double width, double height, double depth, double widthSegments = default(double), double heightSegments = default(double), double depthSegments = default(double));
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
        public extern BoxGeometry(double width, double height, double depth, double widthSegments = default(double), double heightSegments = default(double), double depthSegments = default(double));
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
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface1
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Segments { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class CircleBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface1 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CircleBufferGeometry(double radius = default(double), double segments = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface2 : ParametersInterface2
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface2
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Segments { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class CircleGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface2 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CircleGeometry(double radius = default(double), double segments = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface3 : ParametersInterface3
    {
#pragma warning disable CS0626
        public extern double RadiusTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadiusBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool OpenEnded { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface3
    {
        [FieldProperty]
        double RadiusTop { get; set; }
        [FieldProperty]
        double RadiusBottom { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
        [FieldProperty]
        bool OpenEnded { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class CylinderBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface3 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CylinderBufferGeometry(double radiusTop = default(double), double radiusBottom = default(double), double height = default(double), double radialSegments = default(double), double heightSegments = default(double), bool openEnded = default(bool), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface4 : ParametersInterface4
    {
#pragma warning disable CS0626
        public extern double RadiusTop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadiusBottom { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool OpenEnded { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface4
    {
        [FieldProperty]
        double RadiusTop { get; set; }
        [FieldProperty]
        double RadiusBottom { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
        [FieldProperty]
        bool OpenEnded { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class CylinderGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface4 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern CylinderGeometry(double radiusTop = default(double), double radiusBottom = default(double), double height = default(double), double radiusSegments = default(double), double heightSegments = default(double), bool openEnded = default(bool), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface5 : ParametersInterface5
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Detail { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface5
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Detail { get; set; }
    }
    [External]
    public class DodecahedronGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface5 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern DodecahedronGeometry(double radius, double detail);
#pragma warning restore CS0824
    }
    [External]
    public class EdgesGeometry : BufferGeometry
    {
#pragma warning disable CS0824
        public extern EdgesGeometry(BufferGeometry geometry, double thresholdAngle);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern EdgesGeometry Clone();
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONWorldUVGeneratorInterface : WorldUVGeneratorInterface
    {
        [External]
        public delegate Vector2[] generateTopUVDelegate(Geometry geometry, double indexA, double indexB, double indexC);

#pragma warning disable CS0626
        public extern Vector2[] GenerateTopUV(Geometry geometry, double indexA, double indexB, double indexC);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern generateTopUVDelegate generateTopUV { get; set; }
#pragma warning restore CS0626
        [External]
        public delegate Vector2[] generateSideWallUVDelegate(Geometry geometry, double indexA, double indexB, double indexC, double indexD);

#pragma warning disable CS0626
        public extern Vector2[] GenerateSideWallUV(Geometry geometry, double indexA, double indexB, double indexC, double indexD);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern generateSideWallUVDelegate generateSideWallUV { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface WorldUVGeneratorInterface
    {
        Vector2[] GenerateTopUV(Geometry geometry, double indexA, double indexB, double indexC);
        Vector2[] GenerateSideWallUV(Geometry geometry, double indexA, double indexB, double indexC, double indexD);
    }
    [External]
    public class ExtrudeGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern static WorldUVGeneratorInterface WorldUVGenerator { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ExtrudeGeometry(Shape shape = default(Shape), object options = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern ExtrudeGeometry(Shape[] shapes = default(Shape[]), object options = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void AddShapeList(Shape[] shapes, object options = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddShape(Shape shape, object options = default(object));
#pragma warning restore CS0626
    }
    [External]
    public class IcosahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern IcosahedronGeometry(double radius, double detail);
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface6 : ParametersInterface6
    {
#pragma warning disable CS0626
        public extern Vector3[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface6
    {
        [FieldProperty]
        Vector3[] Points { get; set; }
        [FieldProperty]
        double Segments { get; set; }
        [FieldProperty]
        double PhiStart { get; set; }
        [FieldProperty]
        double PhiLength { get; set; }
    }
    [External]
    public class LatheBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface6 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LatheBufferGeometry(Vector3[] points, double segments = default(double), double phiStart = default(double), double phiLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface7 : ParametersInterface7
    {
#pragma warning disable CS0626
        public extern Vector3[] Points { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface7
    {
        [FieldProperty]
        Vector3[] Points { get; set; }
        [FieldProperty]
        double Segments { get; set; }
        [FieldProperty]
        double PhiStart { get; set; }
        [FieldProperty]
        double PhiLength { get; set; }
    }
    [External]
    public class LatheGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface7 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern LatheGeometry(Vector3[] points, double segments = default(double), double phiStart = default(double), double phiLength = default(double));
#pragma warning restore CS0824
    }
    [External]
    public class OctahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern OctahedronGeometry(double radius, double detail);
#pragma warning restore CS0824
    }
    [External]
    public delegate Vector3 funcDelegate(double u, double v);
    [ObjectLiteral]
    public class JSONParametersInterface8 : ParametersInterface8
    {
#pragma warning disable CS0626
        public extern funcDelegate Func { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Slices { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Stacks { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface8
    {
        [FieldProperty]
        funcDelegate Func { get; set; }
        [FieldProperty]
        double Slices { get; set; }
        [FieldProperty]
        double Stacks { get; set; }
    }
    [External]
    public class ParametricGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface8 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern ParametricGeometry(constructorParam01Delegate func, double slices, double stacks);
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterface9 : ParametersInterface9
    {
#pragma warning disable CS0626
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterface9
    {
        [FieldProperty]
        double Width { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double WidthSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
    }
    [External]
    public class PlaneBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterface9 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PlaneBufferGeometry(double width, double height, double widthSegments = default(double), double heightSegments = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac10 : ParametersInterfac10
    {
#pragma warning disable CS0626
        public extern double Width { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac10
    {
        [FieldProperty]
        double Width { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double WidthSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
    }
    [External]
    public class PlaneGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac10 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern PlaneGeometry(double width, double height, double widthSegments = default(double), double heightSegments = default(double));
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
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Detail { get; set; }
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
        double Radius { get; set; }
        [FieldProperty]
        double Detail { get; set; }
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
        public extern PolyhedronGeometry(Vector3[] vertices, Face3[] faces, double radius = default(double), double detail = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac12 : ParametersInterfac12
    {
#pragma warning disable CS0626
        public extern double InnerRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double OuterRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac12
    {
        [FieldProperty]
        double InnerRadius { get; set; }
        [FieldProperty]
        double OuterRadius { get; set; }
        [FieldProperty]
        double ThetaSegments { get; set; }
        [FieldProperty]
        double PhiSegments { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class RingBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac12 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern RingBufferGeometry(double innerRadius = default(double), double outerRadius = default(double), double thetaSegments = default(double), double phiSegments = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac13 : ParametersInterfac13
    {
#pragma warning disable CS0626
        public extern double InnerRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double OuterRadius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac13
    {
        [FieldProperty]
        double InnerRadius { get; set; }
        [FieldProperty]
        double OuterRadius { get; set; }
        [FieldProperty]
        double ThetaSegments { get; set; }
        [FieldProperty]
        double PhiSegments { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class RingGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac13 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern RingGeometry(double innerRadius = default(double), double outerRadius = default(double), double thetaSegments = default(double), double phiSegments = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [External]
    public class ShapeGeometry : Geometry
    {
#pragma warning disable CS0824
        public extern ShapeGeometry(Shape shape, object options = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0824
        public extern ShapeGeometry(Shape[] shapes, object options = default(object));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern ShapeGeometry AddShapeList(Shape[] shapes, object options);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AddShape(Shape shape, object options = default(object));
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONParametersInterfac14 : ParametersInterfac14
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac14
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double WidthSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
        [FieldProperty]
        double PhiStart { get; set; }
        [FieldProperty]
        double PhiLength { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class SphereBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac14 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SphereBufferGeometry(double radius, double widthSegments = default(double), double heightSegments = default(double), double phiStart = default(double), double phiLength = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac15 : ParametersInterfac15
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double WidthSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double PhiLength { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double ThetaLength { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac15
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double WidthSegments { get; set; }
        [FieldProperty]
        double HeightSegments { get; set; }
        [FieldProperty]
        double PhiStart { get; set; }
        [FieldProperty]
        double PhiLength { get; set; }
        [FieldProperty]
        double ThetaStart { get; set; }
        [FieldProperty]
        double ThetaLength { get; set; }
    }
    [External]
    public class SphereGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac15 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern SphereGeometry(double radius, double widthSegments = default(double), double heightSegments = default(double), double phiStart = default(double), double phiLength = default(double), double thetaStart = default(double), double thetaLength = default(double));
#pragma warning restore CS0824
    }
    [External]
    public class TetrahedronGeometry : PolyhedronGeometry
    {
#pragma warning disable CS0824
        public extern TetrahedronGeometry(double radius = default(double), double detail = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONTextGeometryParameters : TextGeometryParameters
    {
#pragma warning disable CS0626
        public extern Font Font { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double CurveSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool BevelEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BevelThickness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BevelSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface TextGeometryParameters
    {
        [FieldProperty]
        Font Font { get; set; }
        [FieldProperty]
        double Size { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double CurveSegments { get; set; }
        [FieldProperty]
        bool BevelEnabled { get; set; }
        [FieldProperty]
        double BevelThickness { get; set; }
        [FieldProperty]
        double BevelSize { get; set; }
    }
    [ObjectLiteral]
    public class JSONParametersInterfac16 : ParametersInterfac16
    {
#pragma warning disable CS0626
        public extern Font Font { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Height { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double CurveSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool BevelEnabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BevelThickness { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double BevelSize { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac16
    {
        [FieldProperty]
        Font Font { get; set; }
        [FieldProperty]
        double Size { get; set; }
        [FieldProperty]
        double Height { get; set; }
        [FieldProperty]
        double CurveSegments { get; set; }
        [FieldProperty]
        bool BevelEnabled { get; set; }
        [FieldProperty]
        double BevelThickness { get; set; }
        [FieldProperty]
        double BevelSize { get; set; }
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
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Arc { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac17
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Tube { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double TubularSegments { get; set; }
        [FieldProperty]
        double Arc { get; set; }
    }
    [External]
    public class TorusBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac17 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusBufferGeometry(double radius = default(double), double tube = default(double), double radialSegments = default(double), double tubularSegments = default(double), double arc = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac18 : ParametersInterfac18
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Arc { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac18
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Tube { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double TubularSegments { get; set; }
        [FieldProperty]
        double Arc { get; set; }
    }
    [External]
    public class TorusGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac18 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusGeometry(double radius = default(double), double tube = default(double), double radialSegments = default(double), double tubularSegments = default(double), double arc = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac19 : ParametersInterfac19
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double P { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Q { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac19
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Tube { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double TubularSegments { get; set; }
        [FieldProperty]
        double P { get; set; }
        [FieldProperty]
        double Q { get; set; }
        [FieldProperty]
        double HeightScale { get; set; }
    }
    [External]
    public class TorusKnotBufferGeometry : BufferGeometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac19 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusKnotBufferGeometry(double radius = default(double), double tube = default(double), double radialSegments = default(double), double tubularSegments = default(double), double p = default(double), double q = default(double), double heightScale = default(double));
#pragma warning restore CS0824
    }
    [ObjectLiteral]
    public class JSONParametersInterfac20 : ParametersInterfac20
    {
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Tube { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double TubularSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double P { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Q { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double HeightScale { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface ParametersInterfac20
    {
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double Tube { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        double TubularSegments { get; set; }
        [FieldProperty]
        double P { get; set; }
        [FieldProperty]
        double Q { get; set; }
        [FieldProperty]
        double HeightScale { get; set; }
    }
    [External]
    public class TorusKnotGeometry : Geometry
    {
#pragma warning disable CS0626
        [FieldProperty]
        public extern ParametersInterfac20 Parameters { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern TorusKnotGeometry(double radius = default(double), double tube = default(double), double radialSegments = default(double), double tubularSegments = default(double), double p = default(double), double q = default(double), double heightScale = default(double));
#pragma warning restore CS0824
    }
    [External]
    public delegate double constructorParam51Delegate(double u);
    [External]
    public delegate double taperDelegate(double u);
    [ObjectLiteral]
    public class JSONParametersInterfac21 : ParametersInterfac21
    {
#pragma warning disable CS0626
        public extern Path Path { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Segments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Radius { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double RadialSegments { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Closed { get; set; }
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
        double Segments { get; set; }
        [FieldProperty]
        double Radius { get; set; }
        [FieldProperty]
        double RadialSegments { get; set; }
        [FieldProperty]
        bool Closed { get; set; }
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
        public extern TubeGeometry(Path path, double segments = default(double), double radius = default(double), double radiusSegments = default(double), bool closed = default(bool), constructorParam51Delegate taper = default(constructorParam51Delegate));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern static double NoTaper(double u = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static double SinusoidalTaper(double u);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern static void FrenetFrames(Path path, double segments, bool closed);
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
        public extern ArrowHelper(Vector3 dir, Vector3 origin = default(Vector3), double length = default(double), double hex = default(double), double headLength = default(double), double headWidth = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetDirection(Vector3 dir);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetLength(double length, double headLength = default(double), double headWidth = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetColor(double hex);
#pragma warning restore CS0626
    }
    [External]
    public class AxisHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern AxisHelper(double size = default(double));
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
        public extern BoundingBoxHelper(Object3D @object = default(Object3D), double hex = default(double));
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
        public delegate double[] PointMapInterfaceIndexerDelegate(string id);

#pragma warning disable CS0626
        public extern double[] this[string id] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern PointMapInterfaceIndexerDelegate indexer { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface PointMapInterface
    {
        double[] this[string id] { get; set; }
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
        public extern DirectionalLightHelper(Light light, double size = default(double));
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
        public extern EdgesHelper(Object3D @object, double hex = default(double), double thresholdAngle = default(double));
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
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern FaceNormalsHelper(Object3D @object, double size = default(double), double hex = default(double), double linewidth = default(double));
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
        public extern GridHelper(double size, double step);
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void SetColors(double colorCenterLine, double colorGrid);
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
        public extern HemisphereLightHelper(Light light, double sphereSize);
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
        public extern PointLightHelper(Light light, double sphereSize);
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
        public extern SpotLightHelper(Light light, double sphereSize, double arrowLength);
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
        public extern double Size { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
        public extern VertexNormalsHelper(Object3D @object, double size = default(double), double hex = default(double), double linewidth = default(double));
#pragma warning restore CS0824
#pragma warning disable CS0626
        public extern void Update(Object3D @object = default(Object3D));
#pragma warning restore CS0626
    }
    [External]
    public class WireframeHelper : LineSegments
    {
#pragma warning disable CS0824
        public extern WireframeHelper(Object3D @object, double hex = default(double));
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
        public extern void Render(Delegate renderCallback);
#pragma warning restore CS0626
    }
    [ObjectLiteral]
    public class JSONMorphBlendMeshAnimation : MorphBlendMeshAnimation
    {
#pragma warning disable CS0626
        public extern double Start { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double End { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Fps { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double LastFrame { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double CurrentFrame { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool Active { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Time { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Direction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double Weight { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool DirectionBackwards { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern bool MirroredLoop { get; set; }
#pragma warning restore CS0626
    }
    [External]
    public interface MorphBlendMeshAnimation
    {
        [FieldProperty]
        double Start { get; set; }
        [FieldProperty]
        double End { get; set; }
        [FieldProperty]
        double Length { get; set; }
        [FieldProperty]
        double Fps { get; set; }
        [FieldProperty]
        double Duration { get; set; }
        [FieldProperty]
        double LastFrame { get; set; }
        [FieldProperty]
        double CurrentFrame { get; set; }
        [FieldProperty]
        bool Active { get; set; }
        [FieldProperty]
        double Time { get; set; }
        [FieldProperty]
        double Direction { get; set; }
        [FieldProperty]
        double Weight { get; set; }
        [FieldProperty]
        bool DirectionBackwards { get; set; }
        [FieldProperty]
        bool MirroredLoop { get; set; }
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
        public extern void CreateAnimation(string name, double start, double end, double fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void AutoCreateAnimations(double fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDirectionForward(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDirectionBackward(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationFPS(string name, double fps);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationDuration(string name, double duration);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationWeight(string name, double weight);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void SetAnimationTime(string name, double time);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetAnimationTime(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern double GetAnimationDuration(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void PlayAnimation(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void StopAnimation(string name);
#pragma warning restore CS0626
#pragma warning disable CS0626
        public extern void Update(double delta);
#pragma warning restore CS0626
    }

}

[External]
public class ArrayLike<T>
{
#pragma warning disable CS0626
    [FieldProperty]
    public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
    public extern T this[double n] { get; set; }
#pragma warning restore CS0626
}