using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatternCircleSquare {
    internal class DrawingOutput {
        public static void DrawResult(Panel iPanel,float iObjectShapeOne,float iObjectShapeTwo,float iDrawingScale,int Choice) {
            ReSetPanel(iPanel);
            DrawCoordinateAxisOXY(iPanel,iDrawingScale);
            if(Choice==(int)CONST.eCHOICE.ROUND_HOLE_SQUARE_PEG) {
                DrawCircle(iPanel,iObjectShapeOne,iDrawingScale,CONFIG.COLOR_ONE);
                DrawSquare(iPanel,iObjectShapeTwo,iDrawingScale,CONFIG.COLOR_TWO);
                return;
            }
            if(Choice==(int)CONST.eCHOICE.ROUND_HOLE_ROUND_PEG) {
                DrawCircle(iPanel,iObjectShapeOne,iDrawingScale,CONFIG.COLOR_ONE);
                DrawCircle(iPanel,iObjectShapeTwo,iDrawingScale,CONFIG.COLOR_TWO);
                return;
            }
        }
        private static void ReSetPanel(Panel iPanel) {
            Graphics _Graphic = iPanel.CreateGraphics();
            _Graphic.Clear(iPanel.BackColor);
        }
        private static void DrawCoordinateAxisOXY(Panel iPanel,float iDrawingScale) {
            VeRiengOXY(iPanel,iDrawingScale);
            VeDuongDungTrucX(iPanel,iDrawingScale);
            VeDuongNgangTrucY(iPanel,iDrawingScale);
        }
        private static void VeRiengOXY(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            Graphics _Graphic = iPanel.CreateGraphics();

            _Graphic.DrawString(CONST.CHARACTER_O_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter);
            _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter,CONST.ZEROS_COORDINATE,_OxCenter,_Scope);
            _Graphic.DrawString(CONST.CHARACTER_Y_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,CONST.ZEROS_COORDINATE);
            _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME,(iPanel.Width+_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME);
            _Graphic.DrawString(CONST.CHARACTER_X_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),(iPanel.Width+_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME);
        }
        private static void VeDuongDungTrucX(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            _Scope=CONFIG.NUMBER_OF_PLOTS*_Scope/(CONFIG.RESIDUAL_UNIT+CONFIG.NUMBER_OF_PLOTS);
            int _DistanceValue = _Scope/CONFIG.NUMBER_OF_PLOTS;
            Graphics _Graphic = iPanel.CreateGraphics();

            for(int _iLoop = 1;_iLoop<=CONFIG.NUMBER_OF_PLOTS/CONST.TWO_TIME;_iLoop++) {
                //vẽ x dương
                _Graphic.DrawString((_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter+_iLoop*_DistanceValue,_OyCenter);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter+_iLoop*_DistanceValue,_DistanceValue,_OxCenter+_iLoop*_DistanceValue,_Scope+_DistanceValue);
                //vẽ x âm
                _Graphic.DrawString("-"+(_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter-_iLoop*_DistanceValue,_OyCenter);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter-_iLoop*_DistanceValue,_DistanceValue,_OxCenter-_iLoop*_DistanceValue,_Scope+_DistanceValue);
            }
        }
        private static void VeDuongNgangTrucY(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            _Scope=CONFIG.NUMBER_OF_PLOTS*_Scope/(CONFIG.RESIDUAL_UNIT+CONFIG.NUMBER_OF_PLOTS);
            int _DistanceValue = _Scope/CONFIG.NUMBER_OF_PLOTS;
            Graphics _Graphic = iPanel.CreateGraphics();

            for(int _iLoop = 1;_iLoop<=CONFIG.NUMBER_OF_PLOTS/CONST.TWO_TIME;_iLoop++) {
                //vẽ y dương
                _Graphic.DrawString((_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter-_iLoop*_DistanceValue);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,_OyCenter-_iLoop*_DistanceValue,(iPanel.Width+_Scope)/CONST.TWO_TIME,_OyCenter-_iLoop*_DistanceValue);
                //vẽ y âm
                _Graphic.DrawString("-"+(_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter+_iLoop*_DistanceValue);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,_OyCenter+_iLoop*_DistanceValue,(iPanel.Width+_Scope)/CONST.TWO_TIME,_OyCenter+_iLoop*_DistanceValue);
            }
        }
        private static void DrawSquare(Panel iPanel,float iObjectShapeOne,float iDrawingScale,Color iColor) {
            Graphics _Graphic = iPanel.CreateGraphics();
            iObjectShapeOne*=iDrawingScale;
            float _TopLeftX = (float)((iPanel.Width-iObjectShapeOne)/2);
            float _TopLeftY = (float)((iPanel.Height-iObjectShapeOne)/2);
            _Graphic.DrawRectangle(new Pen(iColor),_TopLeftX,_TopLeftY,(float)iObjectShapeOne,(float)iObjectShapeOne);
        }
        private static void DrawCircle(Panel iPanel,float iObjectShapeOne,float iDrawingScale,Color iColor) {
            Graphics _Graphic = iPanel.CreateGraphics();
            iObjectShapeOne*=2*iDrawingScale;
            float _TopLeftX = (float)((iPanel.Width-iObjectShapeOne)/2);
            float _TopLeftY = (float)((iPanel.Height-iObjectShapeOne)/2);
            _Graphic.DrawEllipse(new Pen(iColor),_TopLeftX,_TopLeftY,(float)iObjectShapeOne,(float)iObjectShapeOne);
        }
    }
}