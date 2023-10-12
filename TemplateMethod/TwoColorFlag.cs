namespace TemplateMethod
{
    public abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }
        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
}