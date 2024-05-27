(function (global, undefined) {
    var diagram, fillColor, contentColor, strokeColor, strokeWidth;

    function diagram_load(sender) {
        diagram = sender.get_kendoWidget();
    }
    function diagram_change(args) {
        var element = args.added[0];
        //Change connection type to polyline
        if (element instanceof kendo.dataviz.diagram.Connection) {
            element.type("polyline");
            element.points([]);
            element.refresh();
        }
    }
    function fillColor_load(sender) {
        fillColor = sender;
    }
    function contentColor_load(sender) {
        contentColor = sender;
    }
    function strokeColor_load(sender) {
        strokeColor = sender;
    }
    function strokeWidth_load(sender) {
        strokeWidth = sender;
    }

    /*Custom connectors positioned on the circle*/
    function circleTopLeft(shape) {
        var b = shape.bounds();
        return new kendo.dataviz.diagram.Point(b.center().x - b.width * Math.sin(Math.PI / 4) / 2, b.center().y - b.height * Math.cos(Math.PI / 4) / 2);
    }
    function circleTopRight(shape) {
        var b = shape.bounds();
        return new kendo.dataviz.diagram.Point(b.center().x + b.width * Math.sin(Math.PI / 4) / 2, b.center().y - b.height * Math.cos(Math.PI / 4) / 2);
    }
    function circleBottomLeft(shape) {
        var b = shape.bounds();
        return new kendo.dataviz.diagram.Point(b.center().x - b.width * Math.sin(Math.PI / 4) / 2, b.center().y + b.height * Math.cos(Math.PI / 4) / 2);
    }
    function circleBottomRight(shape) {
        var b = shape.bounds();
        return new kendo.dataviz.diagram.Point(b.center().x + b.width * Math.sin(Math.PI / 4) / 2, b.center().y + b.height * Math.cos(Math.PI / 4) / 2);
    }

    function getOptions() {
        var result = {};

        var fill = fillColor.get_selectedColor(),
            sWidth = strokeWidth.get_value(),
            sColor = strokeColor.get_selectedColor(),
            textColor = contentColor.get_selectedColor();

        if (fill)
            result.fill = fill;

        if ((sWidth !== null && sWidth !== "") || sColor) {
            result.stroke = {};
            if (sWidth !== null && sWidth !== "")
                result.stroke.width = sWidth;
            if (sColor)
                result.stroke.color = sColor;
        }

        if (textColor)
            result.content = { color: textColor };

        return result;
    }

    function applyChanges() {
        var selection = diagram.select(),
            options = getOptions();

        for (var i = 0; i < selection.length; i++) {//apply new options to each selected element
            selection[i].redraw(options);
        }
    }

    global.diagram_load = diagram_load;
    global.diagram_change = diagram_change;
    global.fillColor_load = fillColor_load;
    global.contentColor_load = contentColor_load;
    global.strokeColor_load = strokeColor_load;
    global.strokeWidth_load = strokeWidth_load;

    global.applyChanges = applyChanges;
    global.circleTopLeft = circleTopLeft;
    global.circleTopRight = circleTopRight;
    global.circleBottomLeft = circleBottomLeft;
    global.circleBottomRight = circleBottomRight;
})(window);