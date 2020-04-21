<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>

	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr bgcolor="#9acd32">
						<th align="left">name</th>
						<th align="left">Company</th>
						<th align="left">Age</th>
					</tr>
					<xsl:for-each select="catalog">
						<tr>
							<td>
								<xsl:apply-templates select="name"/>
							</td>
							<td>
								<xsl:value-of select="Company"/>
							</td>
							<td>
								<xsl:value-of select="Age"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>