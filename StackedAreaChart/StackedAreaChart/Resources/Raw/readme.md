# Merchandise exports by continent of destination - Data package

This data package contains the data that powers the chart ["Merchandise exports by continent of destination"](https://ourworldindata.org/grapher/merchandise-exports-by-continent?v=1&csvType=full&useColumnShortNames=false) on the Our World in Data website.

## CSV Structure

The high level structure of the CSV file is that each row is an observation for an entity (usually a country or region) and a timepoint (usually a year).

The first two columns in the CSV file are "Entity" and "Code". "Entity" is the name of the entity (e.g. "United States"). "Code" is the OWID internal entity code that we use if the entity is a country or region. For normal countries, this is the same as the [iso alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) code of the entity (e.g. "USA") - for non-standard countries like historical countries these are custom codes.

The third column is either "Year" or "Day". If the data is annual, this is "Year" and contains only the year as an integer. If the column is "Day", the column contains a date string in the form "YYYY-MM-DD".

The remaining columns are the data columns, each of which is a time series. If the CSV data is downloaded using the "full data" option, then each column corresponds to one time series below. If the CSV data is downloaded using the "only selected data visible in the chart" option then the data columns are transformed depending on the chart type and thus the association with the time series might not be as straightforward.

## Metadata.json structure

The .metadata.json file contains metadata about the data package. The "charts" key contains information to recreate the chart, like the title, subtitle etc.. The "columns" key contains information about each of the columns in the csv, like the unit, timespan covered, citation for the data etc..

## About the data

Our World in Data is almost never the original producer of the data - almost all of the data we use has been compiled by others. If you want to re-use data, it is your responsibility to ensure that you adhere to the sources' license and to credit them correctly. Please note that a single time series may have more than one source - e.g. when we stich together data from different time periods by different producers or when we calculate per capita metrics using population data from a second source.

### How we process data at Our World In Data
All data and visualizations on Our World in Data rely on data sourced from one or several original data providers. Preparing this original data involves several processing steps. Depending on the data, this can include standardizing country names and world region definitions, converting units, calculating derived indicators such as per capita measures, as well as adding or adapting metadata such as the name or the description given to an indicator.
[Read about our data pipeline](https://docs.owid.io/projects/etl/)

## Detailed information about each time series


## Exports to Oceania
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.


Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to Oceania” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to Eastern Europe
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.


Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to Eastern Europe” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to Africa
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to Africa” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to South America
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.

Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to South America” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to North America
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.


Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to North America” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to Western Europe
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.

Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to Western Europe” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


## Exports to Asia
Value of merchandise exports by continental destination as a share of GDP. All partner countries are classified into continent groupings according to OWID's classification.  Calculations use Fouqin and Hugot (CEPII 2016) dyadic trade data.


Unit: %  


### How to cite this data

#### In-line citation
If you have limited space (e.g. in data visualizations), you can use this abbreviated in-line citation:  
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data

#### Full citation
Fouquin and Hugot (CEPII 2016) – processed by Our World in Data. “Exports to Asia” [dataset]. Fouquin and Hugot (CEPII 2016) [original data].
Source: Fouquin and Hugot (CEPII 2016) – processed by Our World In Data

### Additional information about this data
To calculate country exports to the rest of the world, the total value of exports by country, per year, is divided by the country's GDP. Calculations use Fouquin and Hugot (CEPII 2016) dyadic trade data.

The time series 'World' corresponds to the World's total exports (i.e. the sum of exports reported by all countries in the dataset).

The total export values of regional income aggregates have been calculated using the World Bank's income groupings.

Germany's time series is comprised of West Germany, and Germany. East Germany has been excluded for the purposes of Germany's calculations but is included in the World series.
Russia's time series comprises Russia and the USSR. 

Continental groupings are defined according to OWID's classification. Europe has been split into Western Europe including: Austria, Belgium, Denmark, Finland, France, Germany, Greece, Hungary, Italy, the Netherlands, Norway, Portugal, Russia, Spain, Sweden, Switzerland, and the United Kingdom. Remaining European countries have been classified as Eastern Europe.


    