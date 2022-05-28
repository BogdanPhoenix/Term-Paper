using System;
using System.Drawing;

namespace Teacher_Manajar
{
    //Опис налаштувань
    public class Setting : IEquatable<Setting>, ICloneable
    {
        private Color border1 = Color.RoyalBlue;
        private Color border2 = Color.HotPink;
        private int border_size = 1;
        private Color font_color = Color.Black;
        private Color background_form_color = Color.White;
        private Color front_form_color = Color.White;
        private Color button_background = Color.MediumSlateBlue;
        private Color button_text_color = Color.White;
        private Color button_border_color = Color.PaleVioletRed;
        private int button_border_size = 0;


        public Color Border1 { get => border1; set => border1 = value; }
        public Color Border2 { get => border2; set => border2 = value; }
        public int Border_Size { get => border_size; set => border_size = value; }
        public Color Font_Color { get => font_color; set => font_color = value; }
        public Color Background_Form_Color { get => background_form_color; set => background_form_color = value; }
        public Color Front_Form_Color { get => front_form_color; set => front_form_color = value; }
        public Color Button_Background { get => button_background; set => button_background = value; }
        public Color Button_Text_Color { get => button_text_color; set => button_text_color = value; }
        public Color Button_Border_Color { get => button_border_color; set => button_border_color = value; }
        public int Button_Border_Size { get => button_border_size; set => button_border_size = value; }
        //Копіювання об'єктів
        public object Clone()
        {
            return new Setting
            {
                Border1 = this.Border1,
                Border2 = this.Border2,
                Border_Size = this.Border_Size,
                Font_Color = this.Font_Color,
                Background_Form_Color = this.Background_Form_Color,
                Front_Form_Color = this.Front_Form_Color,
                Button_Background = this.Button_Background,
                Button_Text_Color = this.Button_Text_Color,
                Button_Border_Color = this.Button_Border_Color,
                Button_Border_Size = this.Button_Border_Size
            };
        }
        //Перевірка чи однакові об'єкти
        public bool Equals(Setting other)
        {
            return Border1.Equals(other.Border1) &&
                (
                    ReferenceEquals(Border2, other.Border2) ||
                    Border2.Equals(other.Border2)
                ) &&
                (
                    ReferenceEquals(Border_Size, other.Border_Size) ||
                    Border_Size.Equals(other.Border_Size)
                ) &&
                (
                    ReferenceEquals(Font_Color, other.Font_Color) ||
                    Font_Color.Equals(other.Font_Color)
                ) &&
                (
                    ReferenceEquals(Background_Form_Color, other.Background_Form_Color) ||
                    Background_Form_Color.Equals(other.Background_Form_Color)
                ) &&
                (
                    ReferenceEquals(Front_Form_Color, other.Front_Form_Color) ||
                    Front_Form_Color.Equals(other.Front_Form_Color)
                ) &&
                (
                    ReferenceEquals(Button_Background, other.Button_Background) ||
                    Button_Background.Equals(other.Button_Background)
                ) &&
                (
                    ReferenceEquals(Button_Text_Color, other.Button_Text_Color) ||
                    Button_Text_Color.Equals(other.Button_Text_Color)
                ) &&
                (
                    ReferenceEquals(Button_Border_Color, other.Button_Border_Color) ||
                    Button_Border_Color.Equals(other.Button_Border_Color)
                ) &&
                (
                    ReferenceEquals(Button_Border_Size, other.Button_Border_Size) ||
                    Button_Border_Size.Equals(other.Button_Border_Size)
                );
        }
    }
}
