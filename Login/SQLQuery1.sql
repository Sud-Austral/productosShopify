CREATE TABLE D_Data 
    (
    [id]                  NUMERIC (10) NOT NULL,
    [data]                VARCHAR (MAX) NULL,
    [id_data]             VARCHAR (MAX) NULL,
    [estado]              VARCHAR (MAX) NULL,
    [desarrollo]          VARCHAR (MAX) NULL,
    [investigacion]       VARCHAR (MAX) NULL,
    [descripcion]         VARCHAR (MAX) NULL,
    [slogan]              VARCHAR (MAX) NULL,
    [vista]               VARCHAR (MAX) NULL,
    [repositorio_dropbox] VARCHAR (MAX) NULL,
    [logo]                VARCHAR (MAX) NULL,
    )
GO

ALTER TABLE D_Data ADD CONSTRAINT D_Data_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE D_INVESTIGACION 
    (
    [id]                              NUMERIC (10) NOT NULL , 
    [numero]                          FLOAT (53)    NULL,
    [tema]                            VARCHAR (MAX) NULL,
    [responsable]                     VARCHAR (MAX) NULL,
    [fecha_inicio]                    DATETIME      NULL,
    [fecha_avance]                    DATETIME      NULL,
    [fecha_termino]                   DATETIME      NULL,
    [comentario]                      VARCHAR (MAX) NULL,
    [accion]                          VARCHAR (MAX) NULL,
    [seguimiento]                     VARCHAR (MAX) NULL,
    [D_Data_id_data]                  NUMERIC (10) NOT NULL 
    )
GO

ALTER TABLE D_INVESTIGACION ADD CONSTRAINT D_INVESTIGACION_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE D_PRIORIZACION 
    (
    [id]                      NUMERIC (10) NOT NULL ,
    [producto_previo]         VARCHAR (MAX) NULL,
    [nombre]                  VARCHAR (MAX) NULL,
    [secuencia]               FLOAT (53)    NULL,
    [pais]                    VARCHAR (MAX) NULL,
    [integrado]               VARCHAR (MAX) NULL,
    [id_producto]             VARCHAR (MAX) NULL,
    [prioridad]               FLOAT (53)    NULL,
    [estado]                  VARCHAR (MAX) NULL,
    [avance]                  FLOAT (53)    NULL,
    [responsable_desarrollo]  VARCHAR (MAX) NULL,
    [responsable_informacion] VARCHAR (MAX) NULL,
    [tecnologia]              VARCHAR (MAX) NULL,
    [tarea]                   VARCHAR (MAX) NULL,
    [db]                      VARCHAR (MAX) NULL,
    [plataforma]              VARCHAR (MAX) NULL,
    [control_calidad]         VARCHAR (MAX) NULL,
    [odoo]                    VARCHAR (MAX) NULL,
    [shopify]                 VARCHAR (MAX) NULL,
    [fecha_estimada]          DATETIME      NULL,
    [fecha_actualizacion]     DATETIME      NULL,
    [D_Data_id_data]          NUMERIC (10) NOT NULL 
    )
GO

ALTER TABLE D_PRIORIZACION ADD CONSTRAINT D_PRIORIZACION_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE D_PRODUCTO 
    (
     [id] NUMERIC (10) NOT NULL , 
     [corr_Producto]                                               BIGINT        NULL,
    [data]                                                        VARCHAR (MAX) NULL,
    [pais]                                                        VARCHAR (MAX) NULL,
    [id_producto]                                                 VARCHAR (MAX) NULL,
    [producto_asociado]                                          VARCHAR (MAX) NULL,
    [nombre_comercial]                                            VARCHAR (MAX) NULL,
    [estado]                                                      VARCHAR (MAX) NULL,
    [avance]                                                      FLOAT (53)    NULL,
    [responsable_desarrollo]                                      VARCHAR (MAX) NULL,
    [responsable_informacion]                                     VARCHAR (MAX) NULL,
    [tecnologia]                                                  VARCHAR (MAX) NULL,
    [host]                                                       VARCHAR (MAX) NULL,
    [link_odoo]                                                   VARCHAR (MAX) NULL,
    [fecha_publicación]                                           DATETIME    NULL,
    [escala]                                                     VARCHAR (MAX) NULL,
    [periodo]                                                     VARCHAR (MAX) NULL,
    [actualizaciones]                                             VARCHAR (MAX) NULL,
    [tipo_producto]                                               VARCHAR (MAX) NULL,
    [fuentes]                                                    VARCHAR (MAX) NULL,
    [ref_principal]                                              VARCHAR (MAX) NULL,
    [competencia]                                                VARCHAR (MAX) NULL,
    [vista]                                                      VARCHAR (MAX) NULL,
    [repositorio_dropbox]                                         VARCHAR (MAX) NULL,
    [logo]                                                   VARCHAR (MAX) NULL,
    [observaciones]                                               FLOAT (53)    NULL,
    [miniatura]                                                   VARCHAR (MAX) NULL,
    [portada_shopify]                                             VARCHAR (MAX) NULL,
    [parrafo_enganche]                                            VARCHAR (MAX) NULL,
    [variante_1]                                                  VARCHAR (MAX) NULL,
    [precio1_usd]                                              FLOAT (53)    NULL,
    [variante_2]                                                  VARCHAR (MAX) NULL,
    [precio2_usd]                                              FLOAT (53)    NULL,
    [variante_3]                                                  VARCHAR (MAX) NULL,
    [precio3_usd]                                              FLOAT (53)    NULL,
    [variable_filtro1]                                            VARCHAR (MAX)    NULL,
    [variable_filtro2]                                            VARCHAR (MAX)    NULL,
    [variable_filtro3]                                            VARCHAR (MAX)    NULL,
    [descripcion]                                                 VARCHAR (MAX) NULL,
    [CAR_tipo_prod]                                               VARCHAR (MAX) NULL,
    [CAR_var1_disponible]                                         VARCHAR (MAX) NULL,
    [CAR_var2_disponible]                                         VARCHAR (MAX) NULL,
    [CAR_var3_disponible]                                         VARCHAR (MAX) NULL,
    [CAR_periodo]                                                 VARCHAR (MAX) NULL,
    [CAR_proveedor]                                               VARCHAR (MAX) NULL,
    [CAR_colección]                                               VARCHAR (MAX) NULL,
    [ESP_tecnología]                                              VARCHAR (MAX) NULL,
    [ESP_incluye]                                                 VARCHAR (MAX) NULL,
    [ESP_uso_disp]                                               VARCHAR (MAX) NULL,
    [ESP_fuentes ]                                                VARCHAR (MAX) NULL,
    [ACC_recibirás]                                               VARCHAR (MAX) NULL,
    [ACC_licencia_uso]                                            VARCHAR (MAX) NULL,
    [ACC_actualizaciones]                                         VARCHAR (MAX) NULL,
    [ACC_numero_usuarios]                                             FLOAT (53)    NULL,
    [etiquetas]                                                   VARCHAR (MAX) NULL,
     D_PRIORIZACION_id_priorizacion NUMERIC (10) NOT NULL 
    )
GO

ALTER TABLE D_PRODUCTO ADD CONSTRAINT D_PRODUCTO_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE D_SHOPIFY 
    (
     [id]                               NUMERIC (10) NOT NULL , 
     [Handle]                                    VARCHAR (MAX) NULL,
    [Title]                                     VARCHAR (MAX) NULL,
    [Body_HTML]                               VARCHAR (MAX) NULL,
    [Vendor]                                    VARCHAR (MAX) NULL,
    [Type]                                      VARCHAR (MAX) NULL,
    [Tags]                                      VARCHAR (MAX) NULL,
    [Published]                                 BIT           NULL,
    [Option1_Name]                              VARCHAR (MAX) NULL,
    [Option1_Value]                             VARCHAR (MAX) NULL,
    [Option2_Name]                              VARCHAR (MAX) NULL,
    [Option2_Value]                             VARCHAR (MAX) NULL,
    [Option3_Name]                              VARCHAR (MAX) NULL,
    [Option3_Value]                             VARCHAR (MAX) NULL,
    [Variant_SKU]                               VARCHAR (MAX) NULL,
    [Variant_Grams]                             FLOAT (53)    NULL,
    [Variant_Inventory_Tracker]                 VARCHAR (MAX) NULL,
    [Variant_Inventory_Qty]                     FLOAT (53)    NULL,
    [Variant_Inventory_Policy]                  VARCHAR (MAX) NULL,
    [Variant_Fulfillment_Service]               VARCHAR (MAX) NULL,
    [Variant_Price]                             FLOAT (53)    NULL,
    [Variant_Compare_At_Price]                  FLOAT (53)    NULL,
    [Variant_Requires_Shipping]                 BIT           NULL,
    [Variant_Taxable]                           BIT           NULL,
    [Variant_Barcode]                           FLOAT (53)    NULL,
    [Image_Src]                                 VARCHAR (MAX) NULL,
    [Image_Position]                            FLOAT (53)    NULL,
    [Image_Alt_Text]                            FLOAT (53)    NULL,
    [Gift_Card]                                 BIT           NULL,
    [SEO_Title]                                 VARCHAR (MAX)    NULL,
    [SEO_Description]                           VARCHAR (MAX)     NULL,
    [Google_Shopping_Google_Product_Category] VARCHAR (MAX)     NULL,
    [Google_Shopping_Gender]                  VARCHAR (MAX)     NULL,
    [Google_Shopping_Age_Group]               VARCHAR (MAX)     NULL,
    [Google_Shopping_MPN]                     VARCHAR (MAX)     NULL,
    [Google_Shopping_AdWords_Grouping]        VARCHAR (MAX)     NULL,
    [Google_Shopping_AdWords_Labels]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Condition]               VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Product]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Label_0]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Label_1]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Label_2]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Label_3]          VARCHAR (MAX)     NULL,
    [Google_Shopping_Custom_Label_4]          VARCHAR (MAX)     NULL,
    [Variant_Image]                             VARCHAR (MAX)     NULL,
    [Variant_Weight_Unit]                       VARCHAR (MAX) NULL,
    [Variant_Tax_Code]                          VARCHAR (MAX)     NULL,
    [Cost_per_item]                             FLOAT (53)    NULL,
    [Status]                                    VARCHAR (MAX) NULL,
     D_PRODUCTO_id_producto NUMERIC (10) NOT NULL 
    )
GO

ALTER TABLE D_SHOPIFY ADD CONSTRAINT D_SHOPIFY_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

ALTER TABLE D_INVESTIGACION 
    ADD CONSTRAINT D_INVESTIGACION_D_Data_FK FOREIGN KEY 
    ( 
     D_Data_id_data
    ) 
    REFERENCES D_Data 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE D_PRIORIZACION 
    ADD CONSTRAINT D_PRIORIZACION_D_Data_FK FOREIGN KEY 
    ( 
     D_Data_id_data
    ) 
    REFERENCES D_Data 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE D_PRODUCTO 
    ADD CONSTRAINT D_PRODUCTO_D_PRIORIZACION_FK FOREIGN KEY 
    ( 
     D_PRIORIZACION_id_priorizacion
    ) 
    REFERENCES D_PRIORIZACION 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE D_SHOPIFY 
    ADD CONSTRAINT D_SHOPIFY_D_PRODUCTO_FK FOREIGN KEY 
    ( 
     D_PRODUCTO_id_producto
    ) 
    REFERENCES D_PRODUCTO 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO