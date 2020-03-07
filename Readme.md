# What is GTA Transit?
GTA Transit stands for Greater Toronto Area transit. The end goal is to create applications for Android and iOS
that display transit related data. Initially the focus will be on https://www.gotransit.com/en/.

## Projects
This project uses text template code generation to create the GTFS classes.

### Model Generator
Uses the gtfs.xlsx file that contains sheets for all of the field definitions at https://developers.google.com/transit/gtfs/reference#field_definitions.
It uses ExcelDataReader to process the contents of the Excel sheet and turns that into C# models.

#### methodTemplate.txt
Contains the body of a { get; set; } method

#### classTemplate.txt
Contains the body of the full class. The methods generated will be inserted into this template. This project
uses EntityCore and marked the models as abstract. 

#### dbModelTemplate.txt
Implements the EntityCore version of the models project.

### Parser Generator
TODO

#### parserTemplate.txt
TODO

#### parserListTemplate.txt
TODO

#### parserDbSetTemplate.txt
TODO

#### parserProcessTemplate.txt
TODO

## Acknowledgements
GTFS https://developers.google.com/transit/gtfs


